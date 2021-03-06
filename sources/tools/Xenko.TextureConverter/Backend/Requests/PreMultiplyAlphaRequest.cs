// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenko.TextureConverter.Requests
{
    /// <summary>
    /// Request to premultiply the alpha on the texture
    /// </summary>
    class PreMultiplyAlphaRequest : IRequest
    {
        public override RequestType Type { get { return RequestType.PreMultiplyAlpha; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreMultiplyAlphaRequest"/> class.
        /// </summary>
        public PreMultiplyAlphaRequest()
        {
        }
    }
}
