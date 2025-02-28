// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Compilation error when evaluating route. </summary>
    public partial class RouteCompilationError
    {
        /// <summary> Initializes a new instance of RouteCompilationError. </summary>
        internal RouteCompilationError()
        {
        }

        /// <summary> Initializes a new instance of RouteCompilationError. </summary>
        /// <param name="message"> Route error message. </param>
        /// <param name="severity"> Severity of the route error. </param>
        /// <param name="location"> Location where the route error happened. </param>
        internal RouteCompilationError(string message, RouteErrorSeverity? severity, RouteErrorRange location)
        {
            Message = message;
            Severity = severity;
            Location = location;
        }

        /// <summary> Route error message. </summary>
        public string Message { get; }
        /// <summary> Severity of the route error. </summary>
        public RouteErrorSeverity? Severity { get; }
        /// <summary> Location where the route error happened. </summary>
        public RouteErrorRange Location { get; }
    }
}
