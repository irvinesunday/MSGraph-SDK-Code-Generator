// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph2.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type CallRecordItemRequest.
    /// </summary>
    public partial class CallRecordItemRequest : Microsoft.Graph.BaseRequest, ICallRecordItemRequest
    {
        /// <summary>
        /// Constructs a new CallRecordItemRequest.
        /// </summary>
        public CallRecordItemRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<CallRecord> GetAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsync<CallRecord>(null, cancellationToken);
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<CallRecord>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<CallRecord>(null, cancellationToken);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="callrecord">The CallRecord object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<CallRecord> PatchAsync(CallRecord callrecord, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsync<CallRecord>(callrecord, cancellationToken);
        }

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="callrecord">The CallRecord object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<CallRecord>> PatchResponseAsync(CallRecord callrecord, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<CallRecord>(callrecord, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="callrecord">The CallRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<CallRecord> PutAsync(CallRecord callrecord, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Put;
            return this.SendAsync<CallRecord>(callrecord, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="callrecord">The CallRecord object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<CallRecord>> PutResponseAsync(CallRecord callrecord, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Put;
            return this.SendAsyncWithGraphResponse<CallRecord>(callrecord, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICallRecordItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ICallRecordItemRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }
    }
}
