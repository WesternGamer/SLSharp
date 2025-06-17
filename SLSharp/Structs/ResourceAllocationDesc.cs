using SLSharp.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ResourceAllocationDesc
    {
        public ResourceAllocationDesc()
        {
            baseStructure.StructType = new StructType(
            0xbb57e5, 0x49a2, 0x4c23, [0xa5, 0x19, 0xab, 0x92, 0x86, 0xe7, 0x40, 0x14]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public ResourceAllocationDesc(ResourceType _type, IntPtr _desc, uint _state, IntPtr _heap)
        {
            baseStructure.StructType = new StructType(
            0xbb57e5, 0x49a2, 0x4c23, [0xa5, 0x19, 0xab, 0x92, 0x86, 0xe7, 0x40, 0x14]);
            baseStructure.StructVersion = Consts.kStructVersion1;
            type = _type;
            desc = _desc;
            state = _state;
            heap = _heap;
        }

        public readonly BaseStructure baseStructure;

        //! Indicates the type of resource
        public ResourceType type = ResourceType.eTex2d;
        //! D3D12_RESOURCE_DESC/VkImageCreateInfo/VkBufferCreateInfo
        public IntPtr desc = IntPtr.Zero;
        //! Initial state as D3D12_RESOURCE_STATES or VkMemoryPropertyFlags
        public uint state = 0;
        //! CD3DX12_HEAP_PROPERTIES or nullptr
        public IntPtr heap = IntPtr.Zero;
    }
}
