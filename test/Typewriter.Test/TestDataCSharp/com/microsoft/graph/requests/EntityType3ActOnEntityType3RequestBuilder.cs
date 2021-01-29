// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EntityType3ActOnEntityType3RequestBuilder.
    /// </summary>
    public partial class EntityType3ActOnEntityType3RequestBuilder : BaseFunctionMethodRequestBuilder<IEntityType3ActOnEntityType3Request>, IEntityType3ActOnEntityType3RequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="EntityType3ActOnEntityType3RequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="Name">A Name parameter for the OData method call.</param>
        public EntityType3ActOnEntityType3RequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<string> Name)
            : base(requestUrl, client)
        {
            this.SetParameter("name", Name, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IEntityType3ActOnEntityType3Request CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new EntityType3ActOnEntityType3Request(functionUrl, this.Client, options);

            return request;
        }
    }
}
