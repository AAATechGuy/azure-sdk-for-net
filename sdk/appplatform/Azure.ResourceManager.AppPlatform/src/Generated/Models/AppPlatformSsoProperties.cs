// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Single sign-on related configuration. </summary>
    public partial class AppPlatformSsoProperties
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

        /// <summary> Initializes a new instance of <see cref="AppPlatformSsoProperties"/>. </summary>
        public AppPlatformSsoProperties()
        {
            Scope = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSsoProperties"/>. </summary>
        /// <param name="scope"> It defines the specific actions applications can be allowed to do on a user's behalf. </param>
        /// <param name="clientId"> The public identifier for the application. </param>
        /// <param name="clientSecret"> The secret known only to the application and the authorization server. </param>
        /// <param name="issuerUri"> The URI of Issuer Identifier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformSsoProperties(IList<string> scope, string clientId, string clientSecret, Uri issuerUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scope = scope;
            ClientId = clientId;
            ClientSecret = clientSecret;
            IssuerUri = issuerUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> It defines the specific actions applications can be allowed to do on a user's behalf. </summary>
        public IList<string> Scope { get; }
        /// <summary> The public identifier for the application. </summary>
        public string ClientId { get; set; }
        /// <summary> The secret known only to the application and the authorization server. </summary>
        public string ClientSecret { get; set; }
        /// <summary> The URI of Issuer Identifier. </summary>
        public Uri IssuerUri { get; set; }
    }
}
