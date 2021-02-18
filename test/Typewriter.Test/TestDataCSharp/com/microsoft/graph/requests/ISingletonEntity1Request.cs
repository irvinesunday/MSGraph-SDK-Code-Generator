// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISingletonEntity1Request.
    /// </summary>
    public partial interface ISingletonEntity1Request : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SingletonEntity1 using POST.
        /// </summary>
        /// <param name="singletonEntity1ToCreate">The SingletonEntity1 to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SingletonEntity1.</returns>
        System.Threading.Tasks.Task<SingletonEntity1> CreateAsync(SingletonEntity1 singletonEntity1ToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SingletonEntity1 using POST and returns a <see cref="GraphResponse{SingletonEntity1}"/> object.
        /// </summary>
        /// <param name="singletonEntity1ToCreate">The SingletonEntity1 to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SingletonEntity1}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SingletonEntity1>> CreateResponseAsync(SingletonEntity1 singletonEntity1ToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SingletonEntity1.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SingletonEntity1 and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SingletonEntity1.
        /// </summary>
        /// <returns>The SingletonEntity1.</returns>
        System.Threading.Tasks.Task<SingletonEntity1> GetAsync();

        /// <summary>
        /// Gets the specified SingletonEntity1.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SingletonEntity1.</returns>
        System.Threading.Tasks.Task<SingletonEntity1> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SingletonEntity1 and returns a <see cref="GraphResponse{SingletonEntity1}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SingletonEntity1}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SingletonEntity1>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SingletonEntity1 and returns a <see cref="GraphResponse{SingletonEntity1}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SingletonEntity1}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SingletonEntity1>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SingletonEntity1 using PATCH.
        /// </summary>
        /// <param name="singletonEntity1ToUpdate">The SingletonEntity1 to update.</param>
        /// <returns>The updated SingletonEntity1.</returns>
        System.Threading.Tasks.Task<SingletonEntity1> UpdateAsync(SingletonEntity1 singletonEntity1ToUpdate);

        /// <summary>
        /// Updates the specified SingletonEntity1 using PATCH.
        /// </summary>
        /// <param name="singletonEntity1ToUpdate">The SingletonEntity1 to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SingletonEntity1.</returns>
        System.Threading.Tasks.Task<SingletonEntity1> UpdateAsync(SingletonEntity1 singletonEntity1ToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SingletonEntity1 using PATCH and returns a <see cref="GraphResponse{SingletonEntity1}"/> object.
        /// </summary>
        /// <param name="singletonEntity1ToUpdate">The SingletonEntity1 to update.</param>
        /// <returns>The <see cref="GraphResponse{SingletonEntity1}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SingletonEntity1>> UpdateResponseAsync(SingletonEntity1 singletonEntity1ToUpdate);

        /// <summary>
        /// Updates the specified SingletonEntity1 using PATCH and returns a <see cref="GraphResponse{SingletonEntity1}"/> object.
        /// </summary>
        /// <param name="singletonEntity1ToUpdate">The SingletonEntity1 to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SingletonEntity1}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SingletonEntity1>> UpdateResponseAsync(SingletonEntity1 singletonEntity1ToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISingletonEntity1Request Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISingletonEntity1Request Expand(Expression<Func<SingletonEntity1, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISingletonEntity1Request Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISingletonEntity1Request Select(Expression<Func<SingletonEntity1, object>> selectExpression);

    }
}
