// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a queue selector that will be attached to the job. </summary>
    public partial class StaticQueueSelectorAttachment : QueueSelectorAttachment
    {
        /// <summary> Initializes a new instance of StaticQueueSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of QueueSelectorAttachment. </param>
        /// <param name="queueSelector">
        /// Describes a condition that must be met against a set of labels for queue
        /// selection
        /// </param>
        internal StaticQueueSelectorAttachment(string kind, RouterQueueSelector queueSelector) : base(kind)
        {
            QueueSelector = queueSelector;
        }

        /// <summary>
        /// Describes a condition that must be met against a set of labels for queue
        /// selection
        /// </summary>
        public RouterQueueSelector QueueSelector { get; }
    }
}
