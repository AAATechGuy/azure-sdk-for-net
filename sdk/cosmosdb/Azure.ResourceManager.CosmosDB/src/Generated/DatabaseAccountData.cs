// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing the DatabaseAccount data model. </summary>
    public partial class DatabaseAccountData : TrackedResource
    {
        /// <summary> Initializes a new instance of DatabaseAccountData. </summary>
        /// <param name="location"> The location. </param>
        public DatabaseAccountData(AzureLocation location) : base(location)
        {
            DatabaseAccountOfferType = "Standard";
            IpRules = new ChangeTrackingList<IpAddressOrRange>();
            Capabilities = new ChangeTrackingList<DatabaseAccountCapability>();
            WriteLocations = new ChangeTrackingList<DatabaseAccountLocation>();
            ReadLocations = new ChangeTrackingList<DatabaseAccountLocation>();
            Locations = new ChangeTrackingList<DatabaseAccountLocation>();
            FailoverPolicies = new ChangeTrackingList<FailoverPolicy>();
            VirtualNetworkRules = new ChangeTrackingList<VirtualNetworkRule>();
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionData>();
            Cors = new ChangeTrackingList<CorsPolicy>();
            NetworkAclBypassResourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DatabaseAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> Indicates the type of database account. This can only be set at database account creation. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="provisioningState"> The status of the Cosmos DB account at the time the operation was called. The status can be one of following. &apos;Creating&apos; – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. &apos;Succeeded&apos; – the Cosmos DB account is active for use. &apos;Updating&apos; – the Cosmos DB account is being updated. &apos;Deleting&apos; – the Cosmos DB account is being deleted. &apos;Failed&apos; – the Cosmos DB account failed creation. &apos;DeletionFailed&apos; – the Cosmos DB account deletion failed. </param>
        /// <param name="documentEndpoint"> The connection endpoint for the Cosmos DB database account. </param>
        /// <param name="databaseAccountOfferType"> The offer type for the Cosmos DB database account. Default value: Standard. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="isVirtualNetworkFilterEnabled"> Flag to indicate whether to enable/disable Virtual Network ACL rules. </param>
        /// <param name="enableAutomaticFailover"> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </param>
        /// <param name="consistencyPolicy"> The consistency policy for the Cosmos DB database account. </param>
        /// <param name="capabilities"> List of Cosmos DB capabilities for the account. </param>
        /// <param name="writeLocations"> An array that contains the write location for the Cosmos DB account. </param>
        /// <param name="readLocations"> An array that contains of the read locations enabled for the Cosmos DB account. </param>
        /// <param name="locations"> An array that contains all of the locations enabled for the Cosmos DB account. </param>
        /// <param name="failoverPolicies"> An array that contains the regions ordered by their failover priorities. </param>
        /// <param name="virtualNetworkRules"> List of Virtual Network ACL rules configured for the Cosmos DB account. </param>
        /// <param name="privateEndpointConnections"> List of Private Endpoint Connections configured for the Cosmos DB account. </param>
        /// <param name="enableMultipleWriteLocations"> Enables the account to write in multiple locations. </param>
        /// <param name="enableCassandraConnector"> Enables the cassandra connector on the Cosmos DB C* account. </param>
        /// <param name="connectorOffer"> The cassandra connector offer type for the Cosmos DB database C* account. </param>
        /// <param name="disableKeyBasedMetadataWriteAccess"> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </param>
        /// <param name="keyVaultKeyUri"> The URI of the key vault. </param>
        /// <param name="defaultIdentity"> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="enableFreeTier"> Flag to indicate whether Free Tier is enabled. </param>
        /// <param name="apiProperties"> API specific properties. </param>
        /// <param name="enableAnalyticalStorage"> Flag to indicate whether to enable storage analytics. </param>
        /// <param name="analyticalStorageConfiguration"> Analytical storage specific properties. </param>
        /// <param name="instanceId"> A unique identifier assigned to the database account. </param>
        /// <param name="createMode"> Enum to indicate the mode of account creation. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="backupPolicy"> The object representing the policy for taking backups on an account. </param>
        /// <param name="cors"> The CORS policy for the Cosmos DB database account. </param>
        /// <param name="networkAclBypass"> Indicates what services are allowed to bypass firewall checks. </param>
        /// <param name="networkAclBypassResourceIds"> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </param>
        /// <param name="disableLocalAuth"> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </param>
        internal DatabaseAccountData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DatabaseAccountKind? kind, ManagedServiceIdentity identity, string provisioningState, string documentEndpoint, string databaseAccountOfferType, IList<IpAddressOrRange> ipRules, bool? isVirtualNetworkFilterEnabled, bool? enableAutomaticFailover, ConsistencyPolicy consistencyPolicy, IList<DatabaseAccountCapability> capabilities, IReadOnlyList<DatabaseAccountLocation> writeLocations, IReadOnlyList<DatabaseAccountLocation> readLocations, IReadOnlyList<DatabaseAccountLocation> locations, IReadOnlyList<FailoverPolicy> failoverPolicies, IList<VirtualNetworkRule> virtualNetworkRules, IReadOnlyList<PrivateEndpointConnectionData> privateEndpointConnections, bool? enableMultipleWriteLocations, bool? enableCassandraConnector, ConnectorOffer? connectorOffer, bool? disableKeyBasedMetadataWriteAccess, string keyVaultKeyUri, string defaultIdentity, PublicNetworkAccess? publicNetworkAccess, bool? enableFreeTier, ApiProperties apiProperties, bool? enableAnalyticalStorage, AnalyticalStorageConfiguration analyticalStorageConfiguration, string instanceId, CreateMode? createMode, RestoreParameters restoreParameters, BackupPolicy backupPolicy, IList<CorsPolicy> cors, NetworkAclBypass? networkAclBypass, IList<string> networkAclBypassResourceIds, bool? disableLocalAuth) : base(id, name, type, systemData, tags, location)
        {
            Kind = kind;
            Identity = identity;
            ProvisioningState = provisioningState;
            DocumentEndpoint = documentEndpoint;
            DatabaseAccountOfferType = databaseAccountOfferType;
            IpRules = ipRules;
            IsVirtualNetworkFilterEnabled = isVirtualNetworkFilterEnabled;
            EnableAutomaticFailover = enableAutomaticFailover;
            ConsistencyPolicy = consistencyPolicy;
            Capabilities = capabilities;
            WriteLocations = writeLocations;
            ReadLocations = readLocations;
            Locations = locations;
            FailoverPolicies = failoverPolicies;
            VirtualNetworkRules = virtualNetworkRules;
            PrivateEndpointConnections = privateEndpointConnections;
            EnableMultipleWriteLocations = enableMultipleWriteLocations;
            EnableCassandraConnector = enableCassandraConnector;
            ConnectorOffer = connectorOffer;
            DisableKeyBasedMetadataWriteAccess = disableKeyBasedMetadataWriteAccess;
            KeyVaultKeyUri = keyVaultKeyUri;
            DefaultIdentity = defaultIdentity;
            PublicNetworkAccess = publicNetworkAccess;
            EnableFreeTier = enableFreeTier;
            ApiProperties = apiProperties;
            EnableAnalyticalStorage = enableAnalyticalStorage;
            AnalyticalStorageConfiguration = analyticalStorageConfiguration;
            InstanceId = instanceId;
            CreateMode = createMode;
            RestoreParameters = restoreParameters;
            BackupPolicy = backupPolicy;
            Cors = cors;
            NetworkAclBypass = networkAclBypass;
            NetworkAclBypassResourceIds = networkAclBypassResourceIds;
            DisableLocalAuth = disableLocalAuth;
        }

        /// <summary> Indicates the type of database account. This can only be set at database account creation. </summary>
        public DatabaseAccountKind? Kind { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The status of the Cosmos DB account at the time the operation was called. The status can be one of following. &apos;Creating&apos; – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. &apos;Succeeded&apos; – the Cosmos DB account is active for use. &apos;Updating&apos; – the Cosmos DB account is being updated. &apos;Deleting&apos; – the Cosmos DB account is being deleted. &apos;Failed&apos; – the Cosmos DB account failed creation. &apos;DeletionFailed&apos; – the Cosmos DB account deletion failed. </summary>
        public string ProvisioningState { get; }
        /// <summary> The connection endpoint for the Cosmos DB database account. </summary>
        public string DocumentEndpoint { get; }
        /// <summary> The offer type for the Cosmos DB database account. Default value: Standard. </summary>
        public string DatabaseAccountOfferType { get; }
        /// <summary> List of IpRules. </summary>
        public IList<IpAddressOrRange> IpRules { get; }
        /// <summary> Flag to indicate whether to enable/disable Virtual Network ACL rules. </summary>
        public bool? IsVirtualNetworkFilterEnabled { get; set; }
        /// <summary> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </summary>
        public bool? EnableAutomaticFailover { get; set; }
        /// <summary> The consistency policy for the Cosmos DB database account. </summary>
        public ConsistencyPolicy ConsistencyPolicy { get; set; }
        /// <summary> List of Cosmos DB capabilities for the account. </summary>
        public IList<DatabaseAccountCapability> Capabilities { get; }
        /// <summary> An array that contains the write location for the Cosmos DB account. </summary>
        public IReadOnlyList<DatabaseAccountLocation> WriteLocations { get; }
        /// <summary> An array that contains of the read locations enabled for the Cosmos DB account. </summary>
        public IReadOnlyList<DatabaseAccountLocation> ReadLocations { get; }
        /// <summary> An array that contains all of the locations enabled for the Cosmos DB account. </summary>
        public IReadOnlyList<DatabaseAccountLocation> Locations { get; }
        /// <summary> An array that contains the regions ordered by their failover priorities. </summary>
        public IReadOnlyList<FailoverPolicy> FailoverPolicies { get; }
        /// <summary> List of Virtual Network ACL rules configured for the Cosmos DB account. </summary>
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; }
        /// <summary> List of Private Endpoint Connections configured for the Cosmos DB account. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Enables the account to write in multiple locations. </summary>
        public bool? EnableMultipleWriteLocations { get; set; }
        /// <summary> Enables the cassandra connector on the Cosmos DB C* account. </summary>
        public bool? EnableCassandraConnector { get; set; }
        /// <summary> The cassandra connector offer type for the Cosmos DB database C* account. </summary>
        public ConnectorOffer? ConnectorOffer { get; set; }
        /// <summary> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </summary>
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }
        /// <summary> The URI of the key vault. </summary>
        public string KeyVaultKeyUri { get; set; }
        /// <summary> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more. </summary>
        public string DefaultIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Flag to indicate whether Free Tier is enabled. </summary>
        public bool? EnableFreeTier { get; set; }
        /// <summary> API specific properties. </summary>
        public ApiProperties ApiProperties { get; set; }
        /// <summary> Flag to indicate whether to enable storage analytics. </summary>
        public bool? EnableAnalyticalStorage { get; set; }
        /// <summary> Analytical storage specific properties. </summary>
        public AnalyticalStorageConfiguration AnalyticalStorageConfiguration { get; set; }
        /// <summary> A unique identifier assigned to the database account. </summary>
        public string InstanceId { get; }
        /// <summary> Enum to indicate the mode of account creation. </summary>
        public CreateMode? CreateMode { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public RestoreParameters RestoreParameters { get; set; }
        /// <summary> The object representing the policy for taking backups on an account. </summary>
        public BackupPolicy BackupPolicy { get; set; }
        /// <summary> The CORS policy for the Cosmos DB database account. </summary>
        public IList<CorsPolicy> Cors { get; }
        /// <summary> Indicates what services are allowed to bypass firewall checks. </summary>
        public NetworkAclBypass? NetworkAclBypass { get; set; }
        /// <summary> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </summary>
        public IList<string> NetworkAclBypassResourceIds { get; }
        /// <summary> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
    }
}
