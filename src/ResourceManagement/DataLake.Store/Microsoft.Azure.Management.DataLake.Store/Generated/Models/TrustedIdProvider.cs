// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Store;
    using Newtonsoft.Json;
    using Rest;
    using Rest.Serialization;
    using Store;
    using System.Linq;

    /// <summary>
    /// Data Lake Store Trusted Identity Provider information
    /// </summary>
    [JsonTransformation]
    public partial class TrustedIdProvider : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the TrustedIdProvider class.
        /// </summary>
        public TrustedIdProvider() { }

        /// <summary>
        /// Initializes a new instance of the TrustedIdProvider class.
        /// </summary>
        /// <param name="idProvider">The URL of this trusted identity
        /// provider</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        public TrustedIdProvider(string idProvider, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            IdProvider = idProvider;
        }

        /// <summary>
        /// Gets or sets the URL of this trusted identity provider
        /// </summary>
        [JsonProperty(PropertyName = "properties.idProvider")]
        public string IdProvider { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IdProvider == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IdProvider");
            }
        }
    }
}


