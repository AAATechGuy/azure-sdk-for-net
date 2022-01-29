// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the TriggeredJobHistory data model. </summary>
    public partial class TriggeredJobHistoryData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of TriggeredJobHistoryData. </summary>
        public TriggeredJobHistoryData()
        {
            Runs = new ChangeTrackingList<TriggeredJobRun>();
        }

        /// <summary> Initializes a new instance of TriggeredJobHistoryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="runs"> List of triggered web job runs. </param>
        internal TriggeredJobHistoryData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, IList<TriggeredJobRun> runs) : base(id, name, type, systemData, kind)
        {
            Runs = runs;
        }

        /// <summary> List of triggered web job runs. </summary>
        public IList<TriggeredJobRun> Runs { get; }
    }
}
