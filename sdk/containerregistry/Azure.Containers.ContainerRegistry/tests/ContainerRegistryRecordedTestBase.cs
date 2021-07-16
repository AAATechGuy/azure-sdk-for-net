﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.TestFramework;
using Azure.Identity;
using Microsoft.Azure.Management.ContainerRegistry;
using Microsoft.Azure.Management.ContainerRegistry.Models;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

namespace Azure.Containers.ContainerRegistry.Tests
{
    public class ContainerRegistryRecordedTestBase : RecordedTestBase<ContainerRegistryTestEnvironment>
    {
        protected ContainerRegistryRecordedTestBase(bool isAsync) : base(isAsync)
        {
            Sanitizer = new ContainerRegistryRecordedTestSanitizer();
        }

        public ContainerRegistryRecordedTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
            Sanitizer = new ContainerRegistryRecordedTestSanitizer();
        }

        private readonly Dictionary<string, string> _nationalCloudIgnoreTests = new()
        {
            { "GetAccessPoliciesReturnsPolicies", "GetAccessPolicy is currently not supported by Cosmos endpoints." },
            { "GetPropertiesReturnsProperties", "GetProperties is currently not supported by Cosmos endpoints." },
            { "GetTableServiceStatsReturnsStats", "GetStatistics is currently not supported by Cosmos endpoints." },
            { "ValidateSasCredentialsWithRowKeyAndPartitionKeyRanges", "Shared access signature with PartitionKey or RowKey are not supported" },
            { "ValidateAccountSasCredentialsWithPermissions", "SAS for account operations not supported" },
            { "ValidateAccountSasCredentialsWithPermissionsWithSasDuplicatedInUri", "SAS for account operations not supported" },
            { "ValidateAccountSasCredentialsWithResourceTypes", "SAS for account operations not supported" },
            { "CreateEntityWithETagProperty", "https://github.com/Azure/azure-sdk-for-net/issues/21405" }
        };

        public ContainerRegistryClient CreateClient(bool anonymousAccess = false)
        {
            return anonymousAccess ? CreateAnonymousClient() : CreateAuthenticatedClient();
        }

        private ContainerRegistryClient CreateAuthenticatedClient()
        {
            string endpoint = TestEnvironment.Endpoint;
            Uri authorityHost = GetAuthorityHost(endpoint);
            string authenticationScope = GetAuthenticationScope(authorityHost);

            return InstrumentClient(new ContainerRegistryClient(
                    new Uri(endpoint),
                    TestEnvironment.Credential,
                    InstrumentClientOptions(new ContainerRegistryClientOptions()
                    {
                        AuthenticationScope = authenticationScope
                    })
                ));
        }

        private ContainerRegistryClient CreateAnonymousClient()
        {
            string endpoint = TestEnvironment.AnonymousAccessEndpoint;
            Uri authorityHost = GetAuthorityHost(endpoint);
            string authenticationScope = GetAuthenticationScope(authorityHost);

            return InstrumentClient(new ContainerRegistryClient(
                    new Uri(endpoint),
                    InstrumentClientOptions(new ContainerRegistryClientOptions()
                    {
                        AuthenticationScope = authenticationScope
                    })
                ));
        }

        private Uri GetAuthorityHost(string endpoint)
        {
            if (endpoint.Contains(".azurecr.io"))
            {
                return AzureAuthorityHosts.AzurePublicCloud;
            }

            if (endpoint.Contains(".azurecr.cn"))
            {
                return AzureAuthorityHosts.AzureChina;
            }

            if (endpoint.Contains(".azurecr.us"))
            {
                return AzureAuthorityHosts.AzureGovernment;
            }

            if (endpoint.Contains(".azurecr.de"))
            {
                return AzureAuthorityHosts.AzureGermany;
            }

            throw new NotSupportedException($"Cloud for endpoint {endpoint} is not supported.");
        }

        private string GetAuthenticationScope(Uri authorityHost)
        {
            if (authorityHost == AzureAuthorityHosts.AzurePublicCloud)
            {
                return "https://management.core.windows.net/.default";
            }

            if (authorityHost == AzureAuthorityHosts.AzureChina)
            {
                return "https://management.chinacloudapi.cn/.default";
            }

            if (authorityHost == AzureAuthorityHosts.AzureGovernment)
            {
                // ACR's authentication scope for US Government cloud
                return "https://management.usgovcloudapi.net/.default";
            }

            if (authorityHost == AzureAuthorityHosts.AzureGermany)
            {
                return "https://management.microsoftazure.de/";
            }

            throw new NotSupportedException($"Cloud for authority host {authorityHost} is not supported.");
        }

        [SetUp]
        public void ContainerRegistryTestSetup()
        {
            string endpoint = TestEnvironment.Endpoint;
            if (GetAuthorityHost(endpoint) != AzureAuthorityHosts.AzurePublicCloud /*&& anonymous*/)
            {
                TestContext context = TestContext.CurrentContext;
                //bool anonymous = TestContext.CurrentContext.Test.Arguments?.Where(arg => arg.ToString() == "anonymous").FirstOrDefault();

                Assert.Ignore("Anonymous client is not enabled in national clouds.");
            }
        }

        #region Methods using Track 1 Management Plane library

        public async Task ImportImageAsync(string registry, string repository, string tag)
        {
            await ImportImageAsync(registry, repository, new List<string>() { tag });
        }

        public async Task ImportImageAsync(string registry, string repository, List<string> tags)
        {
            var credential = new AzureCredentials(
                new ServicePrincipalLoginInformation
                {
                    ClientId = TestEnvironment.ClientId,
                    ClientSecret = TestEnvironment.ClientSecret,
                },
                TestEnvironment.TenantId,
                GetManagementCloudEnvironment());

            var managementClient = new ContainerRegistryManagementClient(credential.WithDefaultSubscription(TestEnvironment.SubscriptionId));
            managementClient.SubscriptionId = TestEnvironment.SubscriptionId;

            var importSource = new ImportSource
            {
                SourceImage = repository,
                RegistryUri = "registry.hub.docker.com"
            };

            var targetTags = tags.Select(tag => $"{repository}:{tag}");

            await managementClient.Registries.ImportImageAsync(
                resourceGroupName: TestEnvironment.ResourceGroup,
                registryName: registry,
                parameters:
                    new ImportImageParameters
                    {
                        Mode = ImportMode.Force,
                        Source = importSource,
                        TargetTags = targetTags.ToList()
                    });
        }

        /// <summary>
        /// Obtain the track 1 management plane AzureEnvironment value for the
        /// cloud correponding to the configured endpoint.
        /// </summary>
        /// <returns></returns>
        private AzureEnvironment GetManagementCloudEnvironment()
        {
            string endpoint = TestEnvironment.Endpoint;
            Uri authorityHost = GetAuthorityHost(endpoint);

            if (authorityHost == AzureAuthorityHosts.AzurePublicCloud)
            {
                return AzureEnvironment.AzureGlobalCloud;
            }

            if (authorityHost == AzureAuthorityHosts.AzureChina)
            {
                return AzureEnvironment.AzureChinaCloud;
            }

            if (authorityHost == AzureAuthorityHosts.AzureGovernment)
            {
                return AzureEnvironment.AzureUSGovernment;
            }

            if (authorityHost == AzureAuthorityHosts.AzureGermany)
            {
                return AzureEnvironment.AzureGermanCloud;
            }

            throw new NotSupportedException($"Cloud for authority host {authorityHost} is not supported.");
        }
        #endregion
    }
}
