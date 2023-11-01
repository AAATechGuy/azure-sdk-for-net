// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CognitiveServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A Class representing a CognitiveServicesCommitmentPlan along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CognitiveServicesCommitmentPlanResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCognitiveServicesCommitmentPlanResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetCognitiveServicesCommitmentPlan method.
    /// </summary>
    public partial class CognitiveServicesCommitmentPlanResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CognitiveServicesCommitmentPlanResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="commitmentPlanName"> The commitmentPlanName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string commitmentPlanName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics;
        private readonly CommitmentPlansRestOperations _cognitiveServicesCommitmentPlanCommitmentPlansRestClient;
        private readonly CommitmentPlanData _data;

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesCommitmentPlanResource"/> class for mocking. </summary>
        protected CognitiveServicesCommitmentPlanResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CognitiveServicesCommitmentPlanResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CognitiveServicesCommitmentPlanResource(ArmClient client, CommitmentPlanData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesCommitmentPlanResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CognitiveServicesCommitmentPlanResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cognitiveServicesCommitmentPlanCommitmentPlansApiVersion);
            _cognitiveServicesCommitmentPlanCommitmentPlansRestClient = new CommitmentPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cognitiveServicesCommitmentPlanCommitmentPlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CognitiveServices/commitmentPlans";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CommitmentPlanData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of CommitmentPlanAccountAssociationResources in the CognitiveServicesCommitmentPlan. </summary>
        /// <returns> An object representing collection of CommitmentPlanAccountAssociationResources and their operations over a CommitmentPlanAccountAssociationResource. </returns>
        public virtual CommitmentPlanAccountAssociationCollection GetCommitmentPlanAccountAssociations()
        {
            return GetCachedClient(Client => new CommitmentPlanAccountAssociationCollection(Client, Id));
        }

        /// <summary>
        /// Gets the association of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CommitmentPlanAccountAssociationResource>> GetCommitmentPlanAccountAssociationAsync(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            return await GetCommitmentPlanAccountAssociations().GetAsync(commitmentPlanAssociationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the association of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<CommitmentPlanAccountAssociationResource> GetCommitmentPlanAccountAssociation(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            return GetCommitmentPlanAccountAssociations().Get(commitmentPlanAssociationName, cancellationToken);
        }

        /// <summary>
        /// Returns a Cognitive Services commitment plan specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CognitiveServicesCommitmentPlanResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.Get");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlanAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Cognitive Services commitment plan specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CognitiveServicesCommitmentPlanResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.Get");
            scope.Start();
            try
            {
                var response = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlan(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Cognitive Services commitment plan from the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_DeletePlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.Delete");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.DeletePlanAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation(_cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateDeletePlanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Cognitive Services commitment plan from the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_DeletePlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.Delete");
            scope.Start();
            try
            {
                var response = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.DeletePlan(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new CognitiveServicesArmOperation(_cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateDeletePlanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_UpdatePlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The parameters to provide for the created commitment plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<CognitiveServicesCommitmentPlanResource>> UpdateAsync(WaitUntil waitUntil, CognitiveServicesCommitmentPlanPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.Update");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.UpdatePlanAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesCommitmentPlanResource>(new CognitiveServicesCommitmentPlanOperationSource(Client), _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateUpdatePlanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_UpdatePlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The parameters to provide for the created commitment plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<CognitiveServicesCommitmentPlanResource> Update(WaitUntil waitUntil, CognitiveServicesCommitmentPlanPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.Update");
            scope.Start();
            try
            {
                var response = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.UpdatePlan(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesCommitmentPlanResource>(new CognitiveServicesCommitmentPlanOperationSource(Client), _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics, Pipeline, _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.CreateUpdatePlanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<CognitiveServicesCommitmentPlanResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlanAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new CognitiveServicesCommitmentPlanPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<CognitiveServicesCommitmentPlanResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlan(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new CognitiveServicesCommitmentPlanPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<CognitiveServicesCommitmentPlanResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlanAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new CognitiveServicesCommitmentPlanPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<CognitiveServicesCommitmentPlanResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlan(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new CognitiveServicesCommitmentPlanPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<CognitiveServicesCommitmentPlanResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlanAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new CognitiveServicesCommitmentPlanPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetPlan</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<CognitiveServicesCommitmentPlanResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _cognitiveServicesCommitmentPlanCommitmentPlansClientDiagnostics.CreateScope("CognitiveServicesCommitmentPlanResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _cognitiveServicesCommitmentPlanCommitmentPlansRestClient.GetPlan(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new CognitiveServicesCommitmentPlanResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new CognitiveServicesCommitmentPlanPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
