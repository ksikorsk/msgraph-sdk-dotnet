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
    /// The type MediaContentRatingFrance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MediaContentRatingFrance
    {

        /// <summary>
        /// Gets or sets movieRating.
        /// Movies rating selected for France. Possible values are: allAllowed, allBlocked, agesAbove10, agesAbove12, agesAbove16, agesAbove18.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "movieRating", Required = Newtonsoft.Json.Required.Default)]
        public RatingFranceMoviesType? MovieRating { get; set; }
    
        /// <summary>
        /// Gets or sets tvRating.
        /// TV rating selected for France. Possible values are: allAllowed, allBlocked, agesAbove10, agesAbove12, agesAbove16, agesAbove18.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tvRating", Required = Newtonsoft.Json.Required.Default)]
        public RatingFranceTelevisionType? TvRating { get; set; }
    
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
