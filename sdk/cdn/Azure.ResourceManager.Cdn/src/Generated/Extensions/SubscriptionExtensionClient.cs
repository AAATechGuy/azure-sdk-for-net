// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> An internal class to add extension methods to. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _validateClientDiagnostics;
        private ValidateRestOperations _validateRestClient;
        private ClientDiagnostics _profileClientDiagnostics;
        private ProfilesRestOperations _profileRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private CdnManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _resourceUsageClientDiagnostics;
        private ResourceUsageRestOperations _resourceUsageRestClient;
        private ClientDiagnostics _managedRuleSetsClientDiagnostics;
        private ManagedRuleSetsRestOperations _managedRuleSetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
        }

        private ClientDiagnostics ValidateClientDiagnostics => _validateClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ValidateRestOperations ValidateRestClient => _validateRestClient ??= new ValidateRestOperations(ValidateClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics ProfileClientDiagnostics => _profileClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", Profile.ResourceType.Namespace, DiagnosticOptions);
        private ProfilesRestOperations ProfileRestClient => _profileRestClient ??= new ProfilesRestOperations(ProfileClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(Profile.ResourceType));
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private CdnManagementRestOperations DefaultRestClient => _defaultRestClient ??= new CdnManagementRestOperations(DefaultClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics ResourceUsageClientDiagnostics => _resourceUsageClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ResourceUsageRestOperations ResourceUsageRestClient => _resourceUsageRestClient ??= new ResourceUsageRestOperations(ResourceUsageClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics ManagedRuleSetsClientDiagnostics => _managedRuleSetsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ManagedRuleSetsRestOperations ManagedRuleSetsRestClient => _managedRuleSetsRestClient ??= new ManagedRuleSetsRestOperations(ManagedRuleSetsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(Azure.Core.ResourceType resourceType)
        {
            ArmClient.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Validate a Secret in the profile. </summary>
        /// <param name="validateSecretInput"> The Secret source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSecretInput"/> is null. </exception>
        public async virtual Task<Response<ValidateSecretOutput>> ValidateSecretAsync(ValidateSecretInput validateSecretInput, CancellationToken cancellationToken = default)
        {
            if (validateSecretInput == null)
            {
                throw new ArgumentNullException(nameof(validateSecretInput));
            }

            using var scope = ValidateClientDiagnostics.CreateScope("SubscriptionExtensionClient.ValidateSecret");
            scope.Start();
            try
            {
                var response = await ValidateRestClient.SecretAsync(Id.SubscriptionId, validateSecretInput, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Validate a Secret in the profile. </summary>
        /// <param name="validateSecretInput"> The Secret source. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSecretInput"/> is null. </exception>
        public virtual Response<ValidateSecretOutput> ValidateSecret(ValidateSecretInput validateSecretInput, CancellationToken cancellationToken = default)
        {
            if (validateSecretInput == null)
            {
                throw new ArgumentNullException(nameof(validateSecretInput));
            }

            using var scope = ValidateClientDiagnostics.CreateScope("SubscriptionExtensionClient.ValidateSecret");
            scope.Start();
            try
            {
                var response = ValidateRestClient.Secret(Id.SubscriptionId, validateSecretInput, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the Azure Front Door Standard, Azure Front Door Premium, and CDN profiles within an Azure subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Profile" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Profile> GetProfilesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Profile>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = await ProfileRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Profile>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = await ProfileRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the Azure Front Door Standard, Azure Front Door Premium, and CDN profiles within an Azure subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Profile" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Profile> GetProfiles(CancellationToken cancellationToken = default)
        {
            Page<Profile> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = ProfileRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Profile> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = ProfileRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public async virtual Task<Response<CheckNameAvailabilityOutput>> CheckCdnNameAvailabilityWithSubscriptionAsync(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckCdnNameAvailabilityWithSubscription");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckNameAvailabilityWithSubscriptionAsync(Id.SubscriptionId, checkNameAvailabilityInput, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityOutput> CheckCdnNameAvailabilityWithSubscription(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckCdnNameAvailabilityWithSubscription");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckNameAvailabilityWithSubscription(Id.SubscriptionId, checkNameAvailabilityInput, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public async virtual Task<Response<ValidateProbeOutput>> ValidateProbeAsync(ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.ValidateProbe");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.ValidateProbeAsync(Id.SubscriptionId, validateProbeInput, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public virtual Response<ValidateProbeOutput> ValidateProbe(ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.ValidateProbe");
            scope.Start();
            try
            {
                var response = DefaultRestClient.ValidateProbe(Id.SubscriptionId, validateProbeInput, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the quota and actual usage of the CDN profiles under the given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceUsage> GetResourceUsagesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceUsage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = await ResourceUsageRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = await ResourceUsageRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Check the quota and actual usage of the CDN profiles under the given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceUsage> GetResourceUsages(CancellationToken cancellationToken = default)
        {
            Page<ResourceUsage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = ResourceUsageRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceUsage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = ResourceUsageRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all available managed rule sets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedRuleSetDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = await ManagedRuleSetsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedRuleSetDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = await ManagedRuleSetsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all available managed rule sets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(CancellationToken cancellationToken = default)
        {
            Page<ManagedRuleSetDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = ManagedRuleSetsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedRuleSetDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = ManagedRuleSetsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
