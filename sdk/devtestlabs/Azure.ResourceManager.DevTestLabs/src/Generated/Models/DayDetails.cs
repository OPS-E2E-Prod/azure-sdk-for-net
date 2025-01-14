// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of a daily schedule. </summary>
    internal partial class DayDetails
    {
        /// <summary> Initializes a new instance of DayDetails. </summary>
        public DayDetails()
        {
        }

        /// <summary> Initializes a new instance of DayDetails. </summary>
        /// <param name="time"> The time of day the schedule will occur. </param>
        internal DayDetails(string time)
        {
            Time = time;
        }

        /// <summary> The time of day the schedule will occur. </summary>
        public string Time { get; set; }
    }
}
