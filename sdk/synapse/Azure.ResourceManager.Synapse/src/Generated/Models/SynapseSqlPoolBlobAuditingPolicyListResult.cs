// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of Sql pool auditing settings. </summary>
    internal partial class SynapseSqlPoolBlobAuditingPolicyListResult
    {
        /// <summary> Initializes a new instance of SynapseSqlPoolBlobAuditingPolicyListResult. </summary>
        internal SynapseSqlPoolBlobAuditingPolicyListResult()
        {
            Value = new ChangeTrackingList<SynapseSqlPoolBlobAuditingPolicyData>();
        }

        /// <summary> Initializes a new instance of SynapseSqlPoolBlobAuditingPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SynapseSqlPoolBlobAuditingPolicyListResult(IReadOnlyList<SynapseSqlPoolBlobAuditingPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseSqlPoolBlobAuditingPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
