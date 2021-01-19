// Template Source: BaseEntityRequest.java.tt
// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph2.callrecords.requests.extensions;

import com.microsoft.graph.http.IRequestBuilder;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph2.callrecords.models.extensions.Photo;
import java.util.Arrays;
import java.util.EnumSet;
import javax.annotation.Nullable;
import javax.annotation.Nonnull;
import com.microsoft.graph.core.IBaseClient;
import com.microsoft.graph.http.BaseRequest;
import com.microsoft.graph.http.HttpMethod;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Photo Request.
 */
public class PhotoRequest extends BaseRequest<Photo> {
	
    /**
     * The request for the Photo
     *
     * @param requestUrl     the request URL
     * @param client         the service client
     * @param requestOptions the options for this request
     */
    public PhotoRequest(@Nonnull final String requestUrl, @Nonnull final IBaseClient client, @Nullable final java.util.List<? extends com.microsoft.graph.options.Option> requestOptions) {
        super(requestUrl, client, requestOptions, Photo.class);
    }

    /**
     * Gets the Photo from the service
     *
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<Photo> getAsync() {
        return sendAsync(HttpMethod.GET, null);
    }

    /**
     * Gets the Photo from the service
     *
     * @return the Photo from the request
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public Photo get() throws ClientException {
       return send(HttpMethod.GET, null);
    }

    /**
     * Delete this item from the service
     *
     * @return a future with the deletion result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<Photo> deleteAsync() {
        return sendAsync(HttpMethod.DELETE, null);
    }

    /**
     * Delete this item from the service
     * @return the resulting response if the service returns anything on deletion
     *
     * @throws ClientException if there was an exception during the delete operation
     */
    @Nullable
    public Photo delete() throws ClientException {
        return send(HttpMethod.DELETE, null);
    }

    /**
     * Patches this Photo with a source
     *
     * @param sourcePhoto the source object with updates
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<Photo> patchAsync(@Nonnull final Photo sourcePhoto) {
        return sendAsync(HttpMethod.PATCH, sourcePhoto);
    }

    /**
     * Patches this Photo with a source
     *
     * @param sourcePhoto the source object with updates
     * @return the updated Photo
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public Photo patch(@Nonnull final Photo sourcePhoto) throws ClientException {
        return send(HttpMethod.PATCH, sourcePhoto);
    }

    /**
     * Creates a Photo with a new object
     *
     * @param newPhoto the new object to create
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<Photo> postAsync(@Nonnull final Photo newPhoto) {
        return sendAsync(HttpMethod.POST, newPhoto);
    }

    /**
     * Creates a Photo with a new object
     *
     * @param newPhoto the new object to create
     * @return the created Photo
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public Photo post(@Nonnull final Photo newPhoto) throws ClientException {
        return send(HttpMethod.POST, newPhoto);
    }

    /**
     * Creates a Photo with a new object
     *
     * @param newPhoto the object to create/update
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<Photo> putAsync(@Nonnull final Photo newPhoto) {
        return sendAsync(HttpMethod.PUT, newPhoto);
    }

    /**
     * Creates a Photo with a new object
     *
     * @param newPhoto the object to create/update
     * @return the created Photo
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public Photo put(@Nonnull final Photo newPhoto) throws ClientException {
        return send(HttpMethod.PUT, newPhoto);
    }

    /**
     * Sets the select clause for the request
     *
     * @param value the select clause
     * @return the updated request
     */
     @Nonnull
     public PhotoRequest select(@Nonnull final String value) {
         addSelectOption(value);
         return this;
     }

    /**
     * Sets the expand clause for the request
     *
     * @param value the expand clause
     * @return the updated request
     */
     @Nonnull
     public PhotoRequest expand(@Nonnull final String value) {
         addExpandOption(value);
         return this;
     }

}

