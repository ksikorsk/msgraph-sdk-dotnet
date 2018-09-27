// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceCompliancePolicySettingState.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceCompliancePolicySettingState
    {

        /// <summary>
        /// Gets or sets setting.
        /// The setting that is being reported
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "setting", Required = Newtonsoft.Json.Required.Default)]
        public string Setting { get; set; }
    
        /// <summary>
        /// Gets or sets settingName.
        /// Localized/user friendly setting name that is being reported
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingName", Required = Newtonsoft.Json.Required.Default)]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets instanceDisplayName.
        /// Name of setting instance that is being reported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instanceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string InstanceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public ComplianceStatus? State { get; set; }
    
        /// <summary>
        /// Gets or sets errorCode.
        /// Error code for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets errorDescription.
        /// Error description
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorDescription", Required = Newtonsoft.Json.Required.Default)]
        public string ErrorDescription { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// UserId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets userName.
        /// UserName
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets userEmail.
        /// UserEmail
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userEmail", Required = Newtonsoft.Json.Required.Default)]
        public string UserEmail { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// UserPrincipalName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets sources.
        /// Contributing policies
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sources", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SettingSource> Sources { get; set; }
    
        /// <summary>
        /// Gets or sets currentValue.
        /// Current value of setting on device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currentValue", Required = Newtonsoft.Json.Required.Default)]
        public string CurrentValue { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
