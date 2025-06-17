using SLSharp.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Resource
    {
        public Resource()
        {
            baseStructure.StructType = new StructType(
            0x3a9d70cf, 0x2418, 0x4b72, [0x83, 0x91, 0x13, 0xf8, 0x72, 0x1c, 0x72, 0x61]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public Resource(ResourceType _type, IntPtr _native, IntPtr _mem, IntPtr _view, uint _state = uint.MaxValue)
        {
            baseStructure.StructType = new StructType(
            0x3a9d70cf, 0x2418, 0x4b72, [0x83, 0x91, 0x13, 0xf8, 0x72, 0x1c, 0x72, 0x61]);
            baseStructure.StructVersion = Consts.kStructVersion1;
            type = _type;
            native = _native;
            memory = _mem;
            view = _view;
            state = _state;
        }

        public Resource(ResourceType _type, IntPtr _native, uint _state = uint.MaxValue)
        {
            baseStructure.StructType = new StructType(
            0x3a9d70cf, 0x2418, 0x4b72, [0x83, 0x91, 0x13, 0xf8, 0x72, 0x1c, 0x72, 0x61]);
            baseStructure.StructVersion = Consts.kStructVersion1;
            type = _type;
            native = _native;
            state = _state;
        }

        public readonly BaseStructure baseStructure;

        //! Indicates the type of resource
        public ResourceType type = ResourceType.eTex2d;
        //! ID3D11Resource/ID3D12Resource/VkBuffer/VkImage
        public IntPtr native = IntPtr.Zero;
        //! vkDeviceMemory or nullptr
        public IntPtr memory = IntPtr.Zero;
        //! VkImageView/VkBufferView or nullptr
        public IntPtr view = IntPtr.Zero;
        //! State as D3D12_RESOURCE_STATES or VkImageLayout
        //! 
        //! IMPORTANT: State is MANDATORY and needs to be correct when tagged resources are actually used.
        //! 
        public uint state = uint.MaxValue;
        //! Width in pixels
        public uint width = 0;
        //! Height in pixels
        public uint height = 0;
        //! Native format
        public uint nativeFormat = 0;
        //! Number of mip-map levels
        public uint mipLevels = 0;
        //! Number of arrays
        public uint arrayLayers = 0;
        //! Virtual address on GPU (if applicable)
        public ulong gpuVirtualAddress = 0;
        //! VkImageCreateFlags
        public uint flags;
        //! VkImageUsageFlags
        public uint usage = 0;
        //! Reserved for internal use
        public uint reserved = 0;
    }
}
