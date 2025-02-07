// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    internal partial class UnknownAlertsMetaDataProperties
    {
        internal static UnknownAlertsMetaDataProperties DeserializeUnknownAlertsMetaDataProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServiceAlertMetadataIdentifier metadataIdentifier = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataIdentifier"u8))
                {
                    metadataIdentifier = new ServiceAlertMetadataIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAlertsMetaDataProperties(metadataIdentifier);
        }
    }
}
