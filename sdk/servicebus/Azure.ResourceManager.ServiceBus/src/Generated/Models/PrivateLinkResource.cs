// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Information of the private link resource. </summary>
    public partial class PrivateLinkResource : Resource
    {
        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        internal PrivateLinkResource()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"></param>
        /// <param name="requiredMembers"> Required Members. </param>
        /// <param name="requiredZoneNames"> Required Zone Names. </param>
        internal PrivateLinkResource(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames) : base(id, name, type, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> Gets the group id. </summary>
        public string GroupId { get; }
        /// <summary> Required Members. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> Required Zone Names. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
