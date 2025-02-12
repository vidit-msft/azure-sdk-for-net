// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The IPPrefixPropertiesIPPrefixRulesItem. </summary>
    public partial class IPPrefixPropertiesIPPrefixRulesItem
    {
        /// <summary> Initializes a new instance of IPPrefixPropertiesIPPrefixRulesItem. </summary>
        /// <param name="action"> Action to be taken on the configuration. Example: Permit | Deny. </param>
        /// <param name="sequenceNumber"> Sequence to insert to/delete from existing route. Prefix lists are evaluated starting with the lowest sequence number and continue down the list until a match is made. Once a match is made, the permit or deny statement is applied to that network and the rest of the list is ignored. </param>
        /// <param name="networkPrefix"> Network Prefix specifying IPv4/IPv6 packets to be permitted or denied. Example: 1.1.1.0/24 | 3FFE:FFFF:0:CD30::/126. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPrefix"/> is null. </exception>
        public IPPrefixPropertiesIPPrefixRulesItem(CommunityActionType action, long sequenceNumber, string networkPrefix)
        {
            Argument.AssertNotNull(networkPrefix, nameof(networkPrefix));

            Action = action;
            SequenceNumber = sequenceNumber;
            NetworkPrefix = networkPrefix;
        }

        /// <summary> Initializes a new instance of IPPrefixPropertiesIPPrefixRulesItem. </summary>
        /// <param name="action"> Action to be taken on the configuration. Example: Permit | Deny. </param>
        /// <param name="sequenceNumber"> Sequence to insert to/delete from existing route. Prefix lists are evaluated starting with the lowest sequence number and continue down the list until a match is made. Once a match is made, the permit or deny statement is applied to that network and the rest of the list is ignored. </param>
        /// <param name="networkPrefix"> Network Prefix specifying IPv4/IPv6 packets to be permitted or denied. Example: 1.1.1.0/24 | 3FFE:FFFF:0:CD30::/126. </param>
        /// <param name="condition"> Specify prefix-list bounds. </param>
        /// <param name="subnetMaskLength"> SubnetMaskLength gives the minimum NetworkPrefix length to be matched.Possible values for IPv4 are 1 - 32. Possible values of IPv6 are 1 - 128. </param>
        internal IPPrefixPropertiesIPPrefixRulesItem(CommunityActionType action, long sequenceNumber, string networkPrefix, Condition? condition, int? subnetMaskLength)
        {
            Action = action;
            SequenceNumber = sequenceNumber;
            NetworkPrefix = networkPrefix;
            Condition = condition;
            SubnetMaskLength = subnetMaskLength;
        }

        /// <summary> Action to be taken on the configuration. Example: Permit | Deny. </summary>
        public CommunityActionType Action { get; set; }
        /// <summary> Sequence to insert to/delete from existing route. Prefix lists are evaluated starting with the lowest sequence number and continue down the list until a match is made. Once a match is made, the permit or deny statement is applied to that network and the rest of the list is ignored. </summary>
        public long SequenceNumber { get; set; }
        /// <summary> Network Prefix specifying IPv4/IPv6 packets to be permitted or denied. Example: 1.1.1.0/24 | 3FFE:FFFF:0:CD30::/126. </summary>
        public string NetworkPrefix { get; set; }
        /// <summary> Specify prefix-list bounds. </summary>
        public Condition? Condition { get; set; }
        /// <summary> SubnetMaskLength gives the minimum NetworkPrefix length to be matched.Possible values for IPv4 are 1 - 32. Possible values of IPv6 are 1 - 128. </summary>
        public int? SubnetMaskLength { get; set; }
    }
}
