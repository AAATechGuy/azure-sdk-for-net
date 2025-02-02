// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary>
    /// Detection request for batch inference. This is an asynchronous inference that
    /// will need another API to get detection results.
    /// </summary>
    public partial class MultivariateBatchDetectionOptions
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionOptions"/>. </summary>
        /// <param name="dataSource">
        /// Source link to the input data to indicate an accessible Azure Storage URI.
        /// It either points to an Azure Blob Storage folder or points to a CSV file in
        /// Azure Blob Storage, based on your data schema selection. The data schema should
        /// be exactly the same as those used in the training phase. The input data must
        /// contain at least slidingWindow entries preceding the start time of the data
        /// to be detected.
        /// </param>
        /// <param name="startTime">
        /// Start date/time of data for detection, which should
        /// be in ISO 8601 format.
        /// </param>
        /// <param name="endTime">
        /// End date/time of data for detection, which should
        /// be in ISO 8601 format.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSource"/> is null. </exception>
        public MultivariateBatchDetectionOptions(Uri dataSource, DateTimeOffset startTime, DateTimeOffset endTime)
        {
            Argument.AssertNotNull(dataSource, nameof(dataSource));

            DataSource = dataSource;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionOptions"/>. </summary>
        /// <param name="dataSource">
        /// Source link to the input data to indicate an accessible Azure Storage URI.
        /// It either points to an Azure Blob Storage folder or points to a CSV file in
        /// Azure Blob Storage, based on your data schema selection. The data schema should
        /// be exactly the same as those used in the training phase. The input data must
        /// contain at least slidingWindow entries preceding the start time of the data
        /// to be detected.
        /// </param>
        /// <param name="topContributorCount"> Number of top contributed variables for one anomalous time stamp in the response. </param>
        /// <param name="startTime">
        /// Start date/time of data for detection, which should
        /// be in ISO 8601 format.
        /// </param>
        /// <param name="endTime">
        /// End date/time of data for detection, which should
        /// be in ISO 8601 format.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MultivariateBatchDetectionOptions(Uri dataSource, int? topContributorCount, DateTimeOffset startTime, DateTimeOffset endTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataSource = dataSource;
            TopContributorCount = topContributorCount;
            StartTime = startTime;
            EndTime = endTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionOptions"/> for deserialization. </summary>
        internal MultivariateBatchDetectionOptions()
        {
        }

        /// <summary>
        /// Source link to the input data to indicate an accessible Azure Storage URI.
        /// It either points to an Azure Blob Storage folder or points to a CSV file in
        /// Azure Blob Storage, based on your data schema selection. The data schema should
        /// be exactly the same as those used in the training phase. The input data must
        /// contain at least slidingWindow entries preceding the start time of the data
        /// to be detected.
        /// </summary>
        public Uri DataSource { get; set; }
        /// <summary> Number of top contributed variables for one anomalous time stamp in the response. </summary>
        public int? TopContributorCount { get; set; }
        /// <summary>
        /// Start date/time of data for detection, which should
        /// be in ISO 8601 format.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }
        /// <summary>
        /// End date/time of data for detection, which should
        /// be in ISO 8601 format.
        /// </summary>
        public DateTimeOffset EndTime { get; set; }
    }
}
