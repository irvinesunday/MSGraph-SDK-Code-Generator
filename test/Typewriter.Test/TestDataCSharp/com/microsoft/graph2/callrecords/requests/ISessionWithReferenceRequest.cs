// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph2.CallRecords
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISessionWithReferenceRequest.
    /// </summary>
    public partial interface ISessionWithReferenceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Gets the specified Session.
        /// </summary>
        /// <returns>The Session.</returns>
        System.Threading.Tasks.Task<Session> GetAsync();

        /// <summary>
        /// Gets the specified Session.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Session.</returns>
        System.Threading.Tasks.Task<Session> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Session and returns a <see cref="GraphResponse{Session}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Session}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Session>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Session and returns a <see cref="GraphResponse{Session}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Session}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Session>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified Session using POST.
        /// </summary>
        /// <param name="sessionToCreate">The Session to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Session.</returns>
        System.Threading.Tasks.Task<Session> CreateAsync(Session sessionToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified Session using POST and returns a <see cref="GraphResponse{Session}"/> object.
        /// </summary>
        /// <param name="sessionToCreate">The Session to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Session}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Session>> CreateResponseAsync(Session sessionToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified Session using PATCH.
        /// </summary>
        /// <param name="sessionToUpdate">The Session to update.</param>
        /// <returns>The updated Session.</returns>
        System.Threading.Tasks.Task<Session> UpdateAsync(Session sessionToUpdate);

        /// <summary>
        /// Updates the specified Session using PATCH.
        /// </summary>
        /// <param name="sessionToUpdate">The Session to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Session.</returns>
        System.Threading.Tasks.Task<Session> UpdateAsync(Session sessionToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified Session using PATCH and returns a <see cref="GraphResponse{Session}"/> object.
        /// </summary>
        /// <param name="sessionToUpdate">The Session to update.</param>
        /// <returns>The <see cref="GraphResponse{Session}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Session>> UpdateResponseAsync(Session sessionToUpdate);

        /// <summary>
        /// Updates the specified Session using PATCH and returns a <see cref="GraphResponse{Session}"/> object.
        /// </summary>
        /// <param name="sessionToUpdate">The Session to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Session}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Session>> UpdateResponseAsync(Session sessionToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified Session.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified Session and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISessionWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISessionWithReferenceRequest Expand(Expression<Func<Session, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISessionWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISessionWithReferenceRequest Select(Expression<Func<Session, object>> selectExpression);

    }
}
