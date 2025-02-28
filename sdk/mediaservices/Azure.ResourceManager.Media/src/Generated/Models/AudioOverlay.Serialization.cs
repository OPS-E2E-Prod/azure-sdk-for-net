// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class AudioOverlay : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("inputLabel");
            writer.WriteStringValue(InputLabel);
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start");
                writer.WriteStringValue(Start.Value, "P");
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end");
                writer.WriteStringValue(End.Value, "P");
            }
            if (Optional.IsDefined(FadeInDuration))
            {
                writer.WritePropertyName("fadeInDuration");
                writer.WriteStringValue(FadeInDuration.Value, "P");
            }
            if (Optional.IsDefined(FadeOutDuration))
            {
                writer.WritePropertyName("fadeOutDuration");
                writer.WriteStringValue(FadeOutDuration.Value, "P");
            }
            if (Optional.IsDefined(AudioGainLevel))
            {
                writer.WritePropertyName("audioGainLevel");
                writer.WriteNumberValue(AudioGainLevel.Value);
            }
            writer.WriteEndObject();
        }

        internal static AudioOverlay DeserializeAudioOverlay(JsonElement element)
        {
            string odataType = default;
            string inputLabel = default;
            Optional<TimeSpan> start = default;
            Optional<TimeSpan> end = default;
            Optional<TimeSpan> fadeInDuration = default;
            Optional<TimeSpan> fadeOutDuration = default;
            Optional<double> audioGainLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputLabel"))
                {
                    inputLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    start = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("end"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    end = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeInDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fadeInDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeOutDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fadeOutDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("audioGainLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    audioGainLevel = property.Value.GetDouble();
                    continue;
                }
            }
            return new AudioOverlay(odataType, inputLabel, Optional.ToNullable(start), Optional.ToNullable(end), Optional.ToNullable(fadeInDuration), Optional.ToNullable(fadeOutDuration), Optional.ToNullable(audioGainLevel));
        }
    }
}
