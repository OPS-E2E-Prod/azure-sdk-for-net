// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class InferenceContainerProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LivenessRoute))
            {
                writer.WritePropertyName("livenessRoute");
                writer.WriteObjectValue(LivenessRoute);
            }
            if (Optional.IsDefined(ReadinessRoute))
            {
                writer.WritePropertyName("readinessRoute");
                writer.WriteObjectValue(ReadinessRoute);
            }
            if (Optional.IsDefined(ScoringRoute))
            {
                writer.WritePropertyName("scoringRoute");
                writer.WriteObjectValue(ScoringRoute);
            }
            writer.WriteEndObject();
        }

        internal static InferenceContainerProperties DeserializeInferenceContainerProperties(JsonElement element)
        {
            Optional<Route> livenessRoute = default;
            Optional<Route> readinessRoute = default;
            Optional<Route> scoringRoute = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("livenessRoute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    livenessRoute = Route.DeserializeRoute(property.Value);
                    continue;
                }
                if (property.NameEquals("readinessRoute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readinessRoute = Route.DeserializeRoute(property.Value);
                    continue;
                }
                if (property.NameEquals("scoringRoute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scoringRoute = Route.DeserializeRoute(property.Value);
                    continue;
                }
            }
            return new InferenceContainerProperties(livenessRoute.Value, readinessRoute.Value, scoringRoute.Value);
        }
    }
}
