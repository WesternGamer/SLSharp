using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Enums
{
    public enum ResourceType : byte
    {
        eTex2d,
        eBuffer,
        eCommandQueue,
        eCommandBuffer,
        eCommandPool,
        eFence,
        eSwapchain,
        eHostFence,
        // this type means that the only thing we know for sure about this resource is that it's castable to IUnknown
        eUnknown,
        eCount
    }
}
