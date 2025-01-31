//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

#nullable disable

using System;

namespace Microsoft.SqlTools.ServiceLayer.TableDesigner.Contracts
{
    /// <summary>
    /// Base class for component properties
    /// </summary>
    public abstract class ComponentPropertiesBase
    {
        public string Title { get; set; }

        public string AriaLabel { get; set; }

        public Nullable<int> Width { get; set; }

        public bool Enabled { get; set; } = true;
    }
}