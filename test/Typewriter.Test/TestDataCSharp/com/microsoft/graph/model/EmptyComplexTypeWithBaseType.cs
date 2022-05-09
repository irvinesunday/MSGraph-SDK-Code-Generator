// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type EmptyComplexTypeWithBaseType.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EmptyComplexTypeWithBaseType>))]
    public partial class EmptyComplexTypeWithBaseType : Entity
    {

        ///<summary>
        /// The internal EmptyComplexTypeWithBaseType constructor
        ///</summary>
        protected internal EmptyComplexTypeWithBaseType()
        {
            // Don't allow initialization of abstract complex types
        }

    }
}
