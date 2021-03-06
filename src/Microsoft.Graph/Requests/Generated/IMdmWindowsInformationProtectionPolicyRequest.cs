// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IMdmWindowsInformationProtectionPolicyRequest.
    /// </summary>
    public partial interface IMdmWindowsInformationProtectionPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicy using PUT.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToCreate">The MdmWindowsInformationProtectionPolicy to create.</param>
        /// <returns>The created MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> CreateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToCreate);        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicy using PUT.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToCreate">The MdmWindowsInformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> CreateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <returns>The MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> GetAsync();

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PATCH.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy to update.</param>
        /// <returns>The updated MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> UpdateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate);

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PATCH.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MdmWindowsInformationProtectionPolicy.</returns>
        System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> UpdateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Expand(Expression<Func<MdmWindowsInformationProtectionPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMdmWindowsInformationProtectionPolicyRequest Select(Expression<Func<MdmWindowsInformationProtectionPolicy, object>> selectExpression);

    }
}
