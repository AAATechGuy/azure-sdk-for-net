// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Contains the weight percentage and queue selectors to be applied if selected
    /// for weighted distributions.
    /// </summary>
    public partial class QueueWeightedAllocation
    {
        /// <summary> Initializes a new instance of QueueWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="queueSelectors">
        /// A collection of queue selectors that will be applied if this allocation is
        /// selected.
        /// </param>
        internal QueueWeightedAllocation(double weight, IReadOnlyList<RouterQueueSelector> queueSelectors)
        {
            Weight = weight;
            QueueSelectors = queueSelectors;
        }

        /// <summary> The percentage of this weight, expressed as a fraction of 1. </summary>
        public double Weight { get; }
        /// <summary>
        /// A collection of queue selectors that will be applied if this allocation is
        /// selected.
        /// </summary>
        public IReadOnlyList<RouterQueueSelector> QueueSelectors { get; }
    }
}
