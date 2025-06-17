using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ViewportHandle
    {
        public ViewportHandle()
        {
            baseStructure.StructType = new StructType(
            0x171b6435, 0x9b3c, 0x4fc8, [0x99, 0x94, 0xfb, 0xe5, 0x25, 0x69, 0xaa, 0xa4]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public ViewportHandle(uint v)
        {
            baseStructure.StructType = new StructType(
            0x171b6435, 0x9b3c, 0x4fc8, [0x99, 0x94, 0xfb, 0xe5, 0x25, 0x69, 0xaa, 0xa4]);
            baseStructure.StructVersion = Consts.kStructVersion1;

            value = v;
        }

        public static implicit operator uint(ViewportHandle h) => h.value;

        public readonly BaseStructure baseStructure;

        private uint value = uint.MaxValue;
    }
}
