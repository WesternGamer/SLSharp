using SLSharp.Structs;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Dlss.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DlssState
    {
        public DlssState()
        {
            baseStructure.StructType = new StructType(
            0x9366b056, 0x8c01, 0x463c, [0xbb, 0x91, 0xe6, 0x87, 0x82, 0x63, 0x6c, 0xe9]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public readonly BaseStructure baseStructure;

        public ulong estimatedVRAMUsageInBytes = 0;
    }
}
