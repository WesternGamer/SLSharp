using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AdapterInfo
    {
        public AdapterInfo()
        {
            baseStructure.StructType = new StructType(
            0x6d5b51f0, 0x76b, 0x486d, [0x99, 0x95, 0x5a, 0x56, 0x10, 0x43, 0xf5, 0xc1]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public readonly BaseStructure baseStructure;

        //! Locally unique identifier
        IntPtr deviceLUID = IntPtr.Zero;
        //! Size in bytes
        uint deviceLUIDSizeInBytes = 0;
        //! Vulkan Specific, if specified LUID will be ignored
        public IntPtr vkPhysicalDevice = IntPtr.Zero;
    }
}
