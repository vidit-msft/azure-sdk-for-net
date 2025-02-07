// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of NetworkRackSkus. </summary>
    internal partial class NetworkRackSkusListResult
    {
        /// <summary> Initializes a new instance of NetworkRackSkusListResult. </summary>
        internal NetworkRackSkusListResult()
        {
            Value = new ChangeTrackingList<NetworkRackSkuData>();
        }

        /// <summary> Initializes a new instance of NetworkRackSkusListResult. </summary>
        /// <param name="value"> List of NetworkRackSku resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal NetworkRackSkusListResult(IReadOnlyList<NetworkRackSkuData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of NetworkRackSku resources. </summary>
        public IReadOnlyList<NetworkRackSkuData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
