// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    internal class ServerBlobAuditingPolicyOperationSource : IOperationSource<ServerBlobAuditingPolicyResource>
    {
        private readonly ArmClient _client;

        internal ServerBlobAuditingPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerBlobAuditingPolicyResource IOperationSource<ServerBlobAuditingPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerBlobAuditingPolicyData.DeserializeServerBlobAuditingPolicyData(document.RootElement);
            return new ServerBlobAuditingPolicyResource(_client, data);
        }

        async ValueTask<ServerBlobAuditingPolicyResource> IOperationSource<ServerBlobAuditingPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerBlobAuditingPolicyData.DeserializeServerBlobAuditingPolicyData(document.RootElement);
            return new ServerBlobAuditingPolicyResource(_client, data);
        }
    }
}
