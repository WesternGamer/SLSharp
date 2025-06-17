using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SubresourceRange
    {
        public SubresourceRange()
        {
            baseStructure.StructType = new StructType(
            0x8d4c316c, 0xd402, 0x4524, [0x89, 0xa7, 0x14, 0xe7, 0x9e, 0x63, 0x8e, 0x3a]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public readonly BaseStructure baseStructure;

        //! Vulkan subresource aspectMask
        public uint aspectMask;
        //! Vulkan subresource baseMipLevel
        public uint baseMipLevel;
        //! Vulkan subresource levelCount
        public uint levelCount;
        //! Vulkan subresource baseArrayLayer
        public uint baseArrayLayer;
        //! Vulkan subresource layerCount
        public uint layerCount;
    }
}
