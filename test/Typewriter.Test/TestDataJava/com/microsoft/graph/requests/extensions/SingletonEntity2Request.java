// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.requests.extensions;

import com.microsoft.graph.http.IRequestBuilder;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph.concurrency.ICallback;
import com.microsoft.graph.models.extensions.SingletonEntity2;
import com.microsoft.graph.requests.extensions.EntityType3RequestBuilder;
import java.util.Arrays;
import java.util.EnumSet;
import com.microsoft.graph.core.IBaseClient;
import com.microsoft.graph.http.BaseRequest;
import com.microsoft.graph.http.HttpMethod;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Singleton Entity2Request.
 */
public class SingletonEntity2Request extends BaseRequest<SingletonEntity2> {
	
    /**
     * The request for the SingletonEntity2
     *
     * @param requestUrl     the request URL
     * @param client         the service client
     * @param requestOptions the options for this request
     */
    public SingletonEntity2Request(final String requestUrl, final IBaseClient client, final java.util.List<? extends com.microsoft.graph.options.Option> requestOptions) {
        super(requestUrl, client, requestOptions, SingletonEntity2.class);
    }

    /**
     * Gets the SingletonEntity2 from the service
     *
     * @param callback the callback to be called after success or failure
     */
    public void get(final ICallback<? super SingletonEntity2> callback) {
        send(HttpMethod.GET, callback, null);
    }

    /**
     * Gets the SingletonEntity2 from the service
     *
     * @return the SingletonEntity2 from the request
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    public SingletonEntity2 get() throws ClientException {
       return send(HttpMethod.GET, null);
    }

    /**
     * Delete this item from the service
     *
     * @param callback the callback when the deletion action has completed
     */
    public void delete(final ICallback<? super SingletonEntity2> callback) {
        send(HttpMethod.DELETE, callback, null);
    }

    /**
     * Delete this item from the service
     *
     * @throws ClientException if there was an exception during the delete operation
     */
    public void delete() throws ClientException {
        send(HttpMethod.DELETE, null);
    }

    /**
     * Patches this SingletonEntity2 with a source
     *
     * @param sourceSingletonEntity2 the source object with updates
     * @param callback the callback to be called after success or failure
     */
    public void patch(final SingletonEntity2 sourceSingletonEntity2, final ICallback<? super SingletonEntity2> callback) {
        send(HttpMethod.PATCH, callback, sourceSingletonEntity2);
    }

    /**
     * Patches this SingletonEntity2 with a source
     *
     * @param sourceSingletonEntity2 the source object with updates
     * @return the updated SingletonEntity2
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    public SingletonEntity2 patch(final SingletonEntity2 sourceSingletonEntity2) throws ClientException {
        return send(HttpMethod.PATCH, sourceSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the new object to create
     * @param callback the callback to be called after success or failure
     */
    public void post(final SingletonEntity2 newSingletonEntity2, final ICallback<? super SingletonEntity2> callback) {
        send(HttpMethod.POST, callback, newSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the new object to create
     * @return the created SingletonEntity2
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    public SingletonEntity2 post(final SingletonEntity2 newSingletonEntity2) throws ClientException {
        return send(HttpMethod.POST, newSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the object to create/update
     * @param callback the callback to be called after success or failure
     */
    public void put(final SingletonEntity2 newSingletonEntity2, final ICallback<? super SingletonEntity2> callback) {
        send(HttpMethod.PUT, callback, newSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the object to create/update
     * @return the created SingletonEntity2
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    public SingletonEntity2 put(final SingletonEntity2 newSingletonEntity2) throws ClientException {
        return send(HttpMethod.PUT, newSingletonEntity2);
    }

    /**
     * Sets the select clause for the request
     *
     * @param value the select clause
     * @return the updated request
     */
     public SingletonEntity2Request select(final String value) {
         addSelectOption(value);
         return this;
     }

    /**
     * Sets the expand clause for the request
     *
     * @param value the expand clause
     * @return the updated request
     */
     public SingletonEntity2Request expand(final String value) {
         addExpandOption(value);
         return this;
     }

}

