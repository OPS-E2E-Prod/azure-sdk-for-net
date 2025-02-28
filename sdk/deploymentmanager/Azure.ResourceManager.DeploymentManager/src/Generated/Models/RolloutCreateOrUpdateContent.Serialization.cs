// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class RolloutCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identity");
            writer.WriteObjectValue(Identity);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("buildVersion");
            writer.WriteStringValue(BuildVersion);
            if (Optional.IsDefined(ArtifactSourceId))
            {
                writer.WritePropertyName("artifactSourceId");
                writer.WriteStringValue(ArtifactSourceId);
            }
            writer.WritePropertyName("targetServiceTopologyId");
            writer.WriteStringValue(TargetServiceTopologyId);
            writer.WritePropertyName("stepGroups");
            writer.WriteStartArray();
            foreach (var item in StepGroups)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RolloutCreateOrUpdateContent DeserializeRolloutCreateOrUpdateContent(JsonElement element)
        {
            Identity identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string buildVersion = default;
            Optional<string> artifactSourceId = default;
            string targetServiceTopologyId = default;
            IList<StepGroup> stepGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    identity = Identity.DeserializeIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("buildVersion"))
                        {
                            buildVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("artifactSourceId"))
                        {
                            artifactSourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetServiceTopologyId"))
                        {
                            targetServiceTopologyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("stepGroups"))
                        {
                            List<StepGroup> array = new List<StepGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StepGroup.DeserializeStepGroup(item));
                            }
                            stepGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RolloutCreateOrUpdateContent(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, buildVersion, artifactSourceId.Value, targetServiceTopologyId, stepGroups);
        }
    }
}
