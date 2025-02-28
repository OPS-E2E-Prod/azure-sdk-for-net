// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseMigrationSqlDBProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetSqlConnection))
            {
                writer.WritePropertyName("targetSqlConnection");
                writer.WriteObjectValue(TargetSqlConnection);
            }
            if (Optional.IsCollectionDefined(TableList))
            {
                writer.WritePropertyName("tableList");
                writer.WriteStartArray();
                foreach (var item in TableList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(SourceSqlConnection))
            {
                writer.WritePropertyName("sourceSqlConnection");
                writer.WriteObjectValue(SourceSqlConnection);
            }
            if (Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName");
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (Optional.IsDefined(MigrationService))
            {
                writer.WritePropertyName("migrationService");
                writer.WriteStringValue(MigrationService);
            }
            if (Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId");
                writer.WriteStringValue(MigrationOperationId);
            }
            if (Optional.IsDefined(TargetDatabaseCollation))
            {
                writer.WritePropertyName("targetDatabaseCollation");
                writer.WriteStringValue(TargetDatabaseCollation);
            }
            if (Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError");
                writer.WriteStringValue(ProvisioningError);
            }
            writer.WriteEndObject();
        }

        internal static DatabaseMigrationSqlDBProperties DeserializeDatabaseMigrationSqlDBProperties(JsonElement element)
        {
            Optional<SqlDBMigrationStatusDetails> migrationStatusDetails = default;
            Optional<SqlConnectionInformation> targetSqlConnection = default;
            Optional<SqlDBOfflineConfiguration> offlineConfiguration = default;
            Optional<IList<string>> tableList = default;
            ResourceType kind = default;
            Optional<string> scope = default;
            Optional<string> provisioningState = default;
            Optional<string> migrationStatus = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<SqlConnectionInformation> sourceSqlConnection = default;
            Optional<string> sourceDatabaseName = default;
            Optional<string> sourceServerName = default;
            Optional<string> migrationService = default;
            Optional<string> migrationOperationId = default;
            Optional<ErrorInfo> migrationFailureError = default;
            Optional<string> targetDatabaseCollation = default;
            Optional<string> provisioningError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationStatusDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationStatusDetails = SqlDBMigrationStatusDetails.DeserializeSqlDBMigrationStatusDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("targetSqlConnection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetSqlConnection = SqlConnectionInformation.DeserializeSqlConnectionInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("offlineConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offlineConfiguration = SqlDBOfflineConfiguration.DeserializeSqlDBOfflineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("tableList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tableList = array;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationStatus"))
                {
                    migrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceSqlConnection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceSqlConnection = SqlConnectionInformation.DeserializeSqlConnectionInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDatabaseName"))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerName"))
                {
                    sourceServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationService"))
                {
                    migrationService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationOperationId"))
                {
                    migrationOperationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationFailureError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationFailureError = ErrorInfo.DeserializeErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetDatabaseCollation"))
                {
                    targetDatabaseCollation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningError"))
                {
                    provisioningError = property.Value.GetString();
                    continue;
                }
            }
            return new DatabaseMigrationSqlDBProperties(kind, scope.Value, provisioningState.Value, migrationStatus.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), sourceSqlConnection.Value, sourceDatabaseName.Value, sourceServerName.Value, migrationService.Value, migrationOperationId.Value, migrationFailureError.Value, targetDatabaseCollation.Value, provisioningError.Value, migrationStatusDetails.Value, targetSqlConnection.Value, offlineConfiguration.Value, Optional.ToList(tableList));
        }
    }
}
