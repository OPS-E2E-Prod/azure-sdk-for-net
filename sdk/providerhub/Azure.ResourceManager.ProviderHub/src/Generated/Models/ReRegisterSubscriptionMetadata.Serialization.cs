// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ReRegisterSubscriptionMetadata
    {
        internal static ReRegisterSubscriptionMetadata DeserializeReRegisterSubscriptionMetadata(JsonElement element)
        {
            bool enabled = default;
            Optional<int> concurrencyLimit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("concurrencyLimit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    concurrencyLimit = property.Value.GetInt32();
                    continue;
                }
            }
            return new ReRegisterSubscriptionMetadata(enabled, Optional.ToNullable(concurrencyLimit));
        }
    }
}
