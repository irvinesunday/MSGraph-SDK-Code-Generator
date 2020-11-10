// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.requests.extensions;

import com.microsoft.graph.http.IRequestBuilder;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph.concurrency.ICallback;
import com.microsoft.graph.models.extensions.DerivedComplexTypeRequest;
import com.microsoft.graph.models.extensions.ResponseObject;
import java.util.Arrays;
import java.util.EnumSet;

import com.microsoft.graph.requests.extensions.TestTypeQueryCollectionRequestBuilder;
import com.microsoft.graph.requests.extensions.TestTypeQueryCollectionRequest;
import com.microsoft.graph.requests.extensions.TestTypeQueryCollectionResponse;
import com.microsoft.graph.options.FunctionOption;
import com.microsoft.graph.core.IBaseClient;
import com.microsoft.graph.http.BaseActionCollectionRequestBuilder;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Test Type Query Collection Request Builder.
 */
public class TestTypeQueryCollectionRequestBuilder extends BaseActionCollectionRequestBuilder<ResponseObject, TestTypeQueryCollectionRequestBuilder, TestTypeQueryCollectionResponse, TestTypeQueryCollectionPage, TestTypeQueryCollectionRequest> {

    /**
     * The request builder for this collection of TestType
     *
     * @param requestUrl     the request URL
     * @param client         the service client
     * @param requestOptions the options for this request
     * @param requests the requests
     */
    public TestTypeQueryCollectionRequestBuilder(final String requestUrl, final IBaseClient client, final java.util.List<? extends com.microsoft.graph.options.Option> requestOptions, final java.util.List<DerivedComplexTypeRequest> requests) {
        super(requestUrl, client, requestOptions, TestTypeQueryCollectionRequestBuilder.class, TestTypeQueryCollectionRequest.class);
  	 if(requests!=null){
			bodyParams.put("requests", requests);
		}
      }
    
    /**
     * Creates the request
     *
     * @param requestOptions the options for this request
     * @return the TestTypeQueryCollectionRequest instance
     */
     @Override
    public TestTypeQueryCollectionRequest buildRequest(final java.util.List<? extends com.microsoft.graph.options.Option> requestOptions) {
        final TestTypeQueryCollectionRequest request = super.buildRequest(requestOptions);

        if (hasParameter("requests")) {
            request.body.requests = getParameter("requests");
        }
  
        return request;
    }
}
