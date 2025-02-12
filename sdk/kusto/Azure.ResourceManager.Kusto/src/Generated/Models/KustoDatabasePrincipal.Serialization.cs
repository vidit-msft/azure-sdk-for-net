// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoDatabasePrincipal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PrincipalType.ToString());
            if (Optional.IsDefined(Fqn))
            {
                writer.WritePropertyName("fqn"u8);
                writer.WriteStringValue(Fqn);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            writer.WriteEndObject();
        }

        internal static KustoDatabasePrincipal DeserializeKustoDatabasePrincipal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KustoDatabasePrincipalRole role = default;
            string name = default;
            KustoDatabasePrincipalType type = default;
            Optional<string> fqn = default;
            Optional<string> email = default;
            Optional<string> appId = default;
            Optional<string> tenantName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("role"u8))
                {
                    role = new KustoDatabasePrincipalRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new KustoDatabasePrincipalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fqn"u8))
                {
                    fqn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantName"u8))
                {
                    tenantName = property.Value.GetString();
                    continue;
                }
            }
            return new KustoDatabasePrincipal(role, name, type, fqn.Value, email.Value, appId.Value, tenantName.Value);
        }
    }
}
