// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SimpleSchedulePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleRunFrequency))
            {
                writer.WritePropertyName("scheduleRunFrequency");
                writer.WriteStringValue(ScheduleRunFrequency.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ScheduleRunDays))
            {
                writer.WritePropertyName("scheduleRunDays");
                writer.WriteStartArray();
                foreach (var item in ScheduleRunDays)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScheduleRunTimes))
            {
                writer.WritePropertyName("scheduleRunTimes");
                writer.WriteStartArray();
                foreach (var item in ScheduleRunTimes)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule");
                writer.WriteObjectValue(HourlySchedule);
            }
            if (Optional.IsDefined(ScheduleWeeklyFrequency))
            {
                writer.WritePropertyName("scheduleWeeklyFrequency");
                writer.WriteNumberValue(ScheduleWeeklyFrequency.Value);
            }
            writer.WritePropertyName("schedulePolicyType");
            writer.WriteStringValue(SchedulePolicyType);
            writer.WriteEndObject();
        }

        internal static SimpleSchedulePolicy DeserializeSimpleSchedulePolicy(JsonElement element)
        {
            Optional<ScheduleRunType> scheduleRunFrequency = default;
            Optional<IList<DayOfWeek>> scheduleRunDays = default;
            Optional<IList<DateTimeOffset>> scheduleRunTimes = default;
            Optional<HourlySchedule> hourlySchedule = default;
            Optional<int> scheduleWeeklyFrequency = default;
            string schedulePolicyType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleRunFrequency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scheduleRunFrequency = new ScheduleRunType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduleRunDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DayOfWeek> array = new List<DayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToDayOfWeek());
                    }
                    scheduleRunDays = array;
                    continue;
                }
                if (property.NameEquals("scheduleRunTimes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    scheduleRunTimes = array;
                    continue;
                }
                if (property.NameEquals("hourlySchedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hourlySchedule = HourlySchedule.DeserializeHourlySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("scheduleWeeklyFrequency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scheduleWeeklyFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("schedulePolicyType"))
                {
                    schedulePolicyType = property.Value.GetString();
                    continue;
                }
            }
            return new SimpleSchedulePolicy(schedulePolicyType, Optional.ToNullable(scheduleRunFrequency), Optional.ToList(scheduleRunDays), Optional.ToList(scheduleRunTimes), hourlySchedule.Value, Optional.ToNullable(scheduleWeeklyFrequency));
        }
    }
}
