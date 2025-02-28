// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="PolicyResource" /> and their operations.
    /// Each <see cref="PolicyResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PolicyCollection" /> instance call the GetPolicies method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PolicyCollection : ArmCollection, IEnumerable<PolicyResource>, IAsyncEnumerable<PolicyResource>
    {
        private readonly ClientDiagnostics _policyReplicationPoliciesClientDiagnostics;
        private readonly ReplicationPoliciesRestOperations _policyReplicationPoliciesRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="PolicyCollection"/> class for mocking. </summary>
        protected PolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal PolicyCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _policyReplicationPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", PolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PolicyResource.ResourceType, out string policyReplicationPoliciesApiVersion);
            _policyReplicationPoliciesRestClient = new ReplicationPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyReplicationPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create a replication policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies/{policyName}
        /// Operation Id: ReplicationPolicies_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> Replication policy name. </param>
        /// <param name="content"> Create policy input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyName, PolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policyReplicationPoliciesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<PolicyResource>(new PolicyOperationSource(Client), _policyReplicationPoliciesClientDiagnostics, Pipeline, _policyReplicationPoliciesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create a replication policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies/{policyName}
        /// Operation Id: ReplicationPolicies_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> Replication policy name. </param>
        /// <param name="content"> Create policy input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<PolicyResource> CreateOrUpdate(WaitUntil waitUntil, string policyName, PolicyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policyReplicationPoliciesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<PolicyResource>(new PolicyOperationSource(Client), _policyReplicationPoliciesClientDiagnostics, Pipeline, _policyReplicationPoliciesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a replication policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies/{policyName}
        /// Operation Id: ReplicationPolicies_Get
        /// </summary>
        /// <param name="policyName"> Replication policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<PolicyResource>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyReplicationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a replication policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies/{policyName}
        /// Operation Id: ReplicationPolicies_Get
        /// </summary>
        /// <param name="policyName"> Replication policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<PolicyResource> Get(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _policyReplicationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the replication policies for a vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies
        /// Operation Id: ReplicationPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyReplicationPoliciesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyReplicationPoliciesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the replication policies for a vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies
        /// Operation Id: ReplicationPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyReplicationPoliciesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyReplicationPoliciesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies/{policyName}
        /// Operation Id: ReplicationPolicies_Get
        /// </summary>
        /// <param name="policyName"> Replication policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _policyReplicationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationPolicies/{policyName}
        /// Operation Id: ReplicationPolicies_Get
        /// </summary>
        /// <param name="policyName"> Replication policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _policyReplicationPoliciesClientDiagnostics.CreateScope("PolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _policyReplicationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PolicyResource> IEnumerable<PolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PolicyResource> IAsyncEnumerable<PolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
