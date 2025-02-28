// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The load-based autoscale request parameters. </summary>
    public partial class HDInsightAutoScaleCapacity
    {
        /// <summary> Initializes a new instance of HDInsightAutoScaleCapacity. </summary>
        public HDInsightAutoScaleCapacity()
        {
        }

        /// <summary> Initializes a new instance of HDInsightAutoScaleCapacity. </summary>
        /// <param name="minInstanceCount"> The minimum instance count of the cluster. </param>
        /// <param name="maxInstanceCount"> The maximum instance count of the cluster. </param>
        internal HDInsightAutoScaleCapacity(int? minInstanceCount, int? maxInstanceCount)
        {
            MinInstanceCount = minInstanceCount;
            MaxInstanceCount = maxInstanceCount;
        }

        /// <summary> The minimum instance count of the cluster. </summary>
        public int? MinInstanceCount { get; set; }
        /// <summary> The maximum instance count of the cluster. </summary>
        public int? MaxInstanceCount { get; set; }
    }
}
