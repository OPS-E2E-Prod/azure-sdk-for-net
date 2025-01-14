// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Auto scale properties. </summary>
    public partial class AutoScaleProperties
    {
        /// <summary> Initializes a new instance of AutoScaleProperties. </summary>
        public AutoScaleProperties()
        {
        }

        /// <summary> Initializes a new instance of AutoScaleProperties. </summary>
        /// <param name="minNodeCount"></param>
        /// <param name="enabled"></param>
        /// <param name="maxNodeCount"></param>
        internal AutoScaleProperties(int? minNodeCount, bool? enabled, int? maxNodeCount)
        {
            MinNodeCount = minNodeCount;
            Enabled = enabled;
            MaxNodeCount = maxNodeCount;
        }

        /// <summary> Gets or sets the min node count. </summary>
        public int? MinNodeCount { get; set; }
        /// <summary> Gets or sets the enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Gets or sets the max node count. </summary>
        public int? MaxNodeCount { get; set; }
    }
}
