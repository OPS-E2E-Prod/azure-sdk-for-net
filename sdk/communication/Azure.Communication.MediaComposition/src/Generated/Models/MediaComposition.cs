// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Body of a media composition. </summary>
    public partial class MediaComposition
    {
        /// <summary> Initializes a new instance of MediaComposition. </summary>
        public MediaComposition()
        {
            Inputs = new ChangeTrackingDictionary<string, MediaInput>();
            Outputs = new ChangeTrackingDictionary<string, MediaOutput>();
        }

        /// <summary> Initializes a new instance of MediaComposition. </summary>
        /// <param name="id"> Id of the media composition. </param>
        /// <param name="layout"> Configure a layout. </param>
        /// <param name="inputs"> Inputs used in the composition. </param>
        /// <param name="outputs"> Outputs used in the composition. </param>
        /// <param name="streamState"> Provides the state of the media composition. </param>
        internal MediaComposition(string id, MediaCompositionLayout layout, IDictionary<string, MediaInput> inputs, IDictionary<string, MediaOutput> outputs, CompositionStreamState streamState)
        {
            Id = id;
            Layout = layout;
            Inputs = inputs;
            Outputs = outputs;
            StreamState = streamState;
        }

        /// <summary> Id of the media composition. </summary>
        public string Id { get; set; }
        /// <summary> Configure a layout. </summary>
        public MediaCompositionLayout Layout { get; set; }
        /// <summary> Inputs used in the composition. </summary>
        public IDictionary<string, MediaInput> Inputs { get; }
        /// <summary> Outputs used in the composition. </summary>
        public IDictionary<string, MediaOutput> Outputs { get; }
        /// <summary> Provides the state of the media composition. </summary>
        public CompositionStreamState StreamState { get; set; }
    }
}
