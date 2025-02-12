// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    internal partial class IPExtendedCommunityIdList : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPExtendedCommunityIds))
            {
                writer.WritePropertyName("ipExtendedCommunityIds"u8);
                writer.WriteStartArray();
                foreach (var item in IPExtendedCommunityIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IPExtendedCommunityIdList DeserializeIPExtendedCommunityIdList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> ipExtendedCommunityIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipExtendedCommunityIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipExtendedCommunityIds = array;
                    continue;
                }
            }
            return new IPExtendedCommunityIdList(Optional.ToList(ipExtendedCommunityIds));
        }
    }
}
