// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties for updating the scope map.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScopeMapUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ScopeMapUpdateParameters class.
        /// </summary>
        public ScopeMapUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScopeMapUpdateParameters class.
        /// </summary>
        /// <param name="description">The user friendly description of the
        /// scope map.</param>
        /// <param name="actions">The list of scope permissions for registry
        /// artifacts.
        /// E.g. repositories/repository-name/pull,
        /// repositories/repository-name/delete</param>
        public ScopeMapUpdateParameters(string description = default(string), IList<string> actions = default(IList<string>))
        {
            Description = description;
            Actions = actions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the user friendly description of the scope map.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of scope permissions for registry artifacts.
        /// E.g. repositories/repository-name/pull,
        /// repositories/repository-name/delete
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<string> Actions { get; set; }

    }
}