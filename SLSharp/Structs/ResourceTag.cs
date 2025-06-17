using SLSharp.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ResourceTag
    {
        public ResourceTag()
        {
            baseStructure.StructType = new StructType(
            0x4c6a5aad, 0xb445, 0x496c, [0x87, 0xff, 0x1a, 0xf3, 0x84, 0x5b, 0xe6, 0x53]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public unsafe ResourceTag(IntPtr r, BufferType t, ResourceLifecycle l, IntPtr e = default)
        {
            baseStructure.StructType = new StructType(
            0x4c6a5aad, 0xb445, 0x496c, [0x87, 0xff, 0x1a, 0xf3, 0x84, 0x5b, 0xe6, 0x53]);
            baseStructure.StructVersion = Consts.kStructVersion1;

            resource = r;
            type = t;
            lifecycle = l;

            if (e != IntPtr.Zero)
            {
                extent = *(Extent*)e.ToPointer();
            }
        }

        public unsafe ResourceTag(ref Resource r, BufferType t, ResourceLifecycle l, IntPtr e = default)
        {
            baseStructure.StructType = new StructType(
            0x4c6a5aad, 0xb445, 0x496c, [0x87, 0xff, 0x1a, 0xf3, 0x84, 0x5b, 0xe6, 0x53]);
            baseStructure.StructVersion = Consts.kStructVersion1;

            IntPtr resPtr = Marshal.AllocHGlobal(Marshal.SizeOf<Resource>());
            Marshal.StructureToPtr(r, resPtr, false);
            resource = resPtr;
            type = t;
            lifecycle = l;

            if (e != IntPtr.Zero)
            {
                extent = *(Extent*)e.ToPointer();
            }

            Marshal.FreeHGlobal(resPtr);
        }

        public unsafe ResourceTag(ref Resource r, BufferType t, ResourceLifecycle l, Extent e)
        {
            baseStructure.StructType = new StructType(
            0x4c6a5aad, 0xb445, 0x496c, [0x87, 0xff, 0x1a, 0xf3, 0x84, 0x5b, 0xe6, 0x53]);
            baseStructure.StructVersion = Consts.kStructVersion1;

            IntPtr resPtr = Marshal.AllocHGlobal(Marshal.SizeOf<Resource>());
            Marshal.StructureToPtr(r, resPtr, false);
            resource = resPtr;
            type = t;
            lifecycle = l;
            extent = e;

            Marshal.FreeHGlobal(resPtr);
        }

        public readonly BaseStructure baseStructure;

        //! Resource description
        public IntPtr resource = IntPtr.Zero;
        //! Type of the tagged buffer
        public BufferType type = BufferType.kBufferTypeDepth;
        //! The life-cycle for the tag, if resource is volatile a valid command buffer must be specified
        public ResourceLifecycle lifecycle = ResourceLifecycle.eOnlyValidNow;
        //! The area of the tagged resource to use (if using the entire resource leave as null)
        public Extent extent = new();
    }
}
