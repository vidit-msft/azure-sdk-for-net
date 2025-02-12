// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class GetDeviceStatusPropertiesOperationSource : IOperationSource<GetDeviceStatusProperties>
    {
        GetDeviceStatusProperties IOperationSource<GetDeviceStatusProperties>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return GetDeviceStatusProperties.DeserializeGetDeviceStatusProperties(document.RootElement);
        }

        async ValueTask<GetDeviceStatusProperties> IOperationSource<GetDeviceStatusProperties>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return GetDeviceStatusProperties.DeserializeGetDeviceStatusProperties(document.RootElement);
        }
    }
}
