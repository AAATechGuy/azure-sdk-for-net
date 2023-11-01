// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ElasticSan.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A Class representing an ElasticSanVolumeGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ElasticSanVolumeGroupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetElasticSanVolumeGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="ElasticSanResource" /> using the GetElasticSanVolumeGroup method.
    /// </summary>
    public partial class ElasticSanVolumeGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ElasticSanVolumeGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="elasticSanName"> The elasticSanName. </param>
        /// <param name="volumeGroupName"> The volumeGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string elasticSanName, string volumeGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _elasticSanVolumeGroupVolumeGroupsClientDiagnostics;
        private readonly VolumeGroupsRestOperations _elasticSanVolumeGroupVolumeGroupsRestClient;
        private readonly ElasticSanVolumeGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="ElasticSanVolumeGroupResource"/> class for mocking. </summary>
        protected ElasticSanVolumeGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ElasticSanVolumeGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ElasticSanVolumeGroupResource(ArmClient client, ElasticSanVolumeGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticSanVolumeGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ElasticSanVolumeGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticSanVolumeGroupVolumeGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string elasticSanVolumeGroupVolumeGroupsApiVersion);
            _elasticSanVolumeGroupVolumeGroupsRestClient = new VolumeGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, elasticSanVolumeGroupVolumeGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ElasticSan/elasticSans/volumegroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ElasticSanVolumeGroupData Data
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

        /// <summary> Gets a collection of ElasticSanVolumeResources in the ElasticSanVolumeGroup. </summary>
        /// <returns> An object representing collection of ElasticSanVolumeResources and their operations over a ElasticSanVolumeResource. </returns>
        public virtual ElasticSanVolumeCollection GetElasticSanVolumes()
        {
            return GetCachedClient(Client => new ElasticSanVolumeCollection(Client, Id));
        }

        /// <summary>
        /// Get an Volume.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the Volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ElasticSanVolumeResource>> GetElasticSanVolumeAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            return await GetElasticSanVolumes().GetAsync(volumeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an Volume.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the Volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ElasticSanVolumeResource> GetElasticSanVolume(string volumeName, CancellationToken cancellationToken = default)
        {
            return GetElasticSanVolumes().Get(volumeName, cancellationToken);
        }

        /// <summary> Gets a collection of ElasticSanSnapshotResources in the ElasticSanVolumeGroup. </summary>
        /// <returns> An object representing collection of ElasticSanSnapshotResources and their operations over a ElasticSanSnapshotResource. </returns>
        public virtual ElasticSanSnapshotCollection GetElasticSanSnapshots()
        {
            return GetCachedClient(Client => new ElasticSanSnapshotCollection(Client, Id));
        }

        /// <summary>
        /// Get a Volume Snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ElasticSanSnapshotResource>> GetElasticSanSnapshotAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            return await GetElasticSanSnapshots().GetAsync(snapshotName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Volume Snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> The name of the volume snapshot within the given volume group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ElasticSanSnapshotResource> GetElasticSanSnapshot(string snapshotName, CancellationToken cancellationToken = default)
        {
            return GetElasticSanSnapshots().Get(snapshotName, cancellationToken);
        }

        /// <summary>
        /// Get an VolumeGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ElasticSanVolumeGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an VolumeGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ElasticSanVolumeGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupResource.Get");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an VolumeGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticSanArmOperation(_elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete an VolumeGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ElasticSanArmOperation(_elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Update an VolumeGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<ElasticSanVolumeGroupResource>> UpdateAsync(WaitUntil waitUntil, ElasticSanVolumeGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticSanArmOperation<ElasticSanVolumeGroupResource>(new ElasticSanVolumeGroupOperationSource(Client), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update an VolumeGroup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<ElasticSanVolumeGroupResource> Update(WaitUntil waitUntil, ElasticSanVolumeGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupResource.Update");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new ElasticSanArmOperation<ElasticSanVolumeGroupResource>(new ElasticSanVolumeGroupOperationSource(Client), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
    }
}
