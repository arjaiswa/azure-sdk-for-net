// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VIP swap request&apos;s frontend IP configuration object. </summary>
    public partial class LoadBalancerVipSwapRequestFrontendIPConfiguration : WritableSubResource
    {
        /// <summary> Initializes a new instance of LoadBalancerVipSwapRequestFrontendIPConfiguration. </summary>
        public LoadBalancerVipSwapRequestFrontendIPConfiguration()
        {
        }

        /// <summary> A reference to public IP address resource. </summary>
        public SubResource PublicIPAddress { get; set; }
    }
}
