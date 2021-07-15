// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ScheduleRequest.
    /// </summary>
    public partial class ScheduleRequest : BaseRequest, IScheduleRequest
    {
        /// <summary>
        /// Constructs a new ScheduleRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ScheduleRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Schedule using POST.
        /// </summary>
        /// <param name="scheduleToCreate">The Schedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Schedule.</returns>
        public async System.Threading.Tasks.Task<Schedule> CreateAsync(Schedule scheduleToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Schedule>(scheduleToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Schedule using POST and returns a <see cref="GraphResponse{Schedule}"/> object.
        /// </summary>
        /// <param name="scheduleToCreate">The Schedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Schedule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Schedule>> CreateResponseAsync(Schedule scheduleToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Schedule>(scheduleToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Schedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Schedule>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Schedule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Schedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Schedule.</returns>
        public async System.Threading.Tasks.Task<Schedule> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Schedule>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Schedule and returns a <see cref="GraphResponse{Schedule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Schedule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Schedule>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Schedule>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Schedule using PATCH.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Schedule.</returns>
        public async System.Threading.Tasks.Task<Schedule> UpdateAsync(Schedule scheduleToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Schedule>(scheduleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Schedule using PATCH and returns a <see cref="GraphResponse{Schedule}"/> object.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Schedule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Schedule>> UpdateResponseAsync(Schedule scheduleToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Schedule>(scheduleToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Schedule using PUT.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Schedule> PutAsync(Schedule scheduleToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Schedule>(scheduleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Schedule using PUT and returns a <see cref="GraphResponse{Schedule}"/> object.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Schedule}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Schedule>> PutResponseAsync(Schedule scheduleToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Schedule>(scheduleToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IScheduleRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IScheduleRequest Expand(Expression<Func<Schedule, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IScheduleRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IScheduleRequest Select(Expression<Func<Schedule, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="scheduleToInitialize">The <see cref="Schedule"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Schedule scheduleToInitialize)
        {

            if (scheduleToInitialize != null)
            {
                if (scheduleToInitialize.TimesOff != null && scheduleToInitialize.TimesOff.CurrentPage != null)
                {
                    scheduleToInitialize.TimesOff.InitializeNextPageRequest(this.Client, scheduleToInitialize.TimesOffNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    scheduleToInitialize.TimesOff.AdditionalData = scheduleToInitialize.AdditionalData;
                }
                if (scheduleToInitialize.TimeOffRequests != null && scheduleToInitialize.TimeOffRequests.CurrentPage != null)
                {
                    scheduleToInitialize.TimeOffRequests.InitializeNextPageRequest(this.Client, scheduleToInitialize.TimeOffRequestsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    scheduleToInitialize.TimeOffRequests.AdditionalData = scheduleToInitialize.AdditionalData;
                }

            }


        }
    }
}
