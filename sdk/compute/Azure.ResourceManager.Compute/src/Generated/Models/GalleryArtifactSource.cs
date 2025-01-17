// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The source image from which the Image Version is going to be created. </summary>
    internal partial class GalleryArtifactSource
    {
        /// <summary> Initializes a new instance of GalleryArtifactSource. </summary>
        /// <param name="managedImage"> The managed artifact. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedImage"/> is null. </exception>
        internal GalleryArtifactSource(SubResource managedImage)
        {
            if (managedImage == null)
            {
                throw new ArgumentNullException(nameof(managedImage));
            }

            ManagedImage = managedImage;
        }

        /// <summary> The managed artifact. </summary>
        internal SubResource ManagedImage { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier ManagedImageId
        {
            get => ManagedImage?.Id;
        }
    }
}
