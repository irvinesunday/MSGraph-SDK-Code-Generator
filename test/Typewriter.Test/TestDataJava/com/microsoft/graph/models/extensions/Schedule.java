// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.models.extensions;
import com.microsoft.graph.serializer.ISerializer;
import com.microsoft.graph.serializer.IJsonBackedObject;
import com.microsoft.graph.serializer.AdditionalDataManager;
import java.util.EnumSet;
import com.microsoft.graph.http.BaseCollectionPage;
import com.microsoft.graph.models.extensions.TimeOff;
import com.microsoft.graph.models.extensions.TimeOffRequest;
import com.microsoft.graph.models.extensions.Entity;
import com.microsoft.graph.requests.extensions.TimeOffCollectionPage;
import com.microsoft.graph.requests.extensions.TimeOffRequestCollectionPage;


import com.google.gson.JsonObject;
import com.google.gson.annotations.SerializedName;
import com.google.gson.annotations.Expose;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Schedule.
 */
public class Schedule extends Entity implements IJsonBackedObject {


    /**
     * The Enabled.
     * 
     */
    @SerializedName(value = "enabled", alternate = {"Enabled"})
    @Expose
    public Boolean enabled;

    /**
     * The Times Off.
     * 
     */
    @SerializedName(value = "timesOff", alternate = {"TimesOff"})
    @Expose
    public TimeOffCollectionPage timesOff;

    /**
     * The Time Off Requests.
     * 
     */
    @SerializedName(value = "timeOffRequests", alternate = {"TimeOffRequests"})
    @Expose
    public TimeOffRequestCollectionPage timeOffRequests;


    /**
     * The raw representation of this class
     */
    private JsonObject rawObject;

    /**
     * The serializer
     */
    private ISerializer serializer;

    /**
     * Gets the raw representation of this class
     *
     * @return the raw representation of this class
     */
    public JsonObject getRawObject() {
        return rawObject;
    }

    /**
     * Gets serializer
     *
     * @return the serializer
     */
	@Override
    public ISerializer getSerializer() {
        return serializer;
    }

    /**
     * Sets the raw JSON object
     *
     * @param serializer the serializer
     * @param json the JSON object to set this object to
     */
    public void setRawObject(final ISerializer serializer, final JsonObject json) {
        this.serializer = serializer;
        rawObject = json;


        if (json.has("timesOff")) {
            timesOff = serializer.deserializeObject(json.get("timesOff").toString(), TimeOffCollectionPage.class);
        }

        if (json.has("timeOffRequests")) {
            timeOffRequests = serializer.deserializeObject(json.get("timeOffRequests").toString(), TimeOffRequestCollectionPage.class);
        }
    }
}
