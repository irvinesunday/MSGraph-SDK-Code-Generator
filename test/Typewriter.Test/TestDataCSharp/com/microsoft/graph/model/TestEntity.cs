﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Test Entity.
    /// </summary>
    public partial class TestEntity : Entity
    {
    
		///<summary>
		/// The TestEntity constructor
		///</summary>
        public TestEntity()
        {
            this.ODataType = "microsoft.graph.testEntity";
        }
	
        /// <summary>
        /// Gets or sets test nav.
        /// </summary>
        [JsonPropertyName("testNav")]
        public TestType TestNav { get; set; }
    
        /// <summary>
        /// Gets or sets test invalid nav.
        /// </summary>
        [JsonPropertyName("testInvalidNav")]
        public EntityType2 TestInvalidNav { get; set; }
    
        /// <summary>
        /// Gets or sets test explicit nav.
        /// </summary>
        [Obsolete("entityType3 is deprecated. Please use singletonEntity1.")]
        [JsonPropertyName("testExplicitNav")]
        public EntityType3 TestExplicitNav { get; set; }
    
    }
}

