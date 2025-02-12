// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="ClusterManagerResource" /> and their operations.
    /// Each <see cref="ClusterManagerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ClusterManagerCollection" /> instance call the GetClusterManagers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ClusterManagerCollection : ArmCollection, IEnumerable<ClusterManagerResource>, IAsyncEnumerable<ClusterManagerResource>
    {
        private readonly ClientDiagnostics _clusterManagerClientDiagnostics;
        private readonly ClusterManagersRestOperations _clusterManagerRestClient;

        /// <summary> Initializes a new instance of the <see cref="ClusterManagerCollection"/> class for mocking. </summary>
        protected ClusterManagerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ClusterManagerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ClusterManagerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _clusterManagerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", ClusterManagerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ClusterManagerResource.ResourceType, out string clusterManagerApiVersion);
            _clusterManagerRestClient = new ClusterManagersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, clusterManagerApiVersion);
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
        /// Create a new cluster manager or update properties of the cluster manager if it exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ClusterManagerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clusterManagerName, ClusterManagerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterManagerName, nameof(clusterManagerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _clusterManagerClientDiagnostics.CreateScope("ClusterManagerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _clusterManagerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<ClusterManagerResource>(new ClusterManagerOperationSource(Client), _clusterManagerClientDiagnostics, Pipeline, _clusterManagerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new cluster manager or update properties of the cluster manager if it exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ClusterManagerResource> CreateOrUpdate(WaitUntil waitUntil, string clusterManagerName, ClusterManagerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterManagerName, nameof(clusterManagerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _clusterManagerClientDiagnostics.CreateScope("ClusterManagerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _clusterManagerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<ClusterManagerResource>(new ClusterManagerOperationSource(Client), _clusterManagerClientDiagnostics, Pipeline, _clusterManagerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the properties of the provided cluster manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> is null. </exception>
        public virtual async Task<Response<ClusterManagerResource>> GetAsync(string clusterManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterManagerName, nameof(clusterManagerName));

            using var scope = _clusterManagerClientDiagnostics.CreateScope("ClusterManagerCollection.Get");
            scope.Start();
            try
            {
                var response = await _clusterManagerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ClusterManagerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of the provided cluster manager.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> is null. </exception>
        public virtual Response<ClusterManagerResource> Get(string clusterManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterManagerName, nameof(clusterManagerName));

            using var scope = _clusterManagerClientDiagnostics.CreateScope("ClusterManagerCollection.Get");
            scope.Start();
            try
            {
                var response = _clusterManagerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ClusterManagerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of cluster managers in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterManagerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _clusterManagerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _clusterManagerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ClusterManagerResource(Client, ClusterManagerData.DeserializeClusterManagerData(e)), _clusterManagerClientDiagnostics, Pipeline, "ClusterManagerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of cluster managers in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterManagerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _clusterManagerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _clusterManagerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ClusterManagerResource(Client, ClusterManagerData.DeserializeClusterManagerData(e)), _clusterManagerClientDiagnostics, Pipeline, "ClusterManagerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clusterManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterManagerName, nameof(clusterManagerName));

            using var scope = _clusterManagerClientDiagnostics.CreateScope("ClusterManagerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _clusterManagerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusterManagers/{clusterManagerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterManagers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterManagerName"> The name of the cluster manager. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterManagerName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterManagerName, nameof(clusterManagerName));

            using var scope = _clusterManagerClientDiagnostics.CreateScope("ClusterManagerCollection.Exists");
            scope.Start();
            try
            {
                var response = _clusterManagerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterManagerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ClusterManagerResource> IEnumerable<ClusterManagerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ClusterManagerResource> IAsyncEnumerable<ClusterManagerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
