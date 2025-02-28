// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Identity for the resource. Currently not supported. </summary>
    public partial class PhpWorkloadResourceIdentity : UserAssignedServiceIdentity
    {
        /// <summary> Initializes a new instance of PhpWorkloadResourceIdentity. </summary>
        /// <param name="managedServiceIdentityType"> Type of manage identity. </param>
        public PhpWorkloadResourceIdentity(ManagedServiceIdentityType managedServiceIdentityType) : base(managedServiceIdentityType)
        {
        }

        /// <summary> Initializes a new instance of PhpWorkloadResourceIdentity. </summary>
        /// <param name="managedServiceIdentityType"> Type of manage identity. </param>
        /// <param name="userAssignedIdentities"> User assigned identities dictionary. </param>
        internal PhpWorkloadResourceIdentity(ManagedServiceIdentityType managedServiceIdentityType, IDictionary<string, UserAssignedIdentity> userAssignedIdentities) : base(managedServiceIdentityType, userAssignedIdentities)
        {
        }
    }
}
