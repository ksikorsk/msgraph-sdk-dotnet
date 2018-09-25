// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RecipientScopeType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum RecipientScopeType
    {
    
        /// <summary>
        /// none
        /// </summary>
        None = 0,
	
        /// <summary>
        /// internal
        /// </summary>
        Internal = 1,
	
        /// <summary>
        /// external
        /// </summary>
        External = 2,
	
        /// <summary>
        /// external Partner
        /// </summary>
        ExternalPartner = 4,
	
        /// <summary>
        /// external Non Partner
        /// </summary>
        ExternalNonPartner = 8,
	
    }
}