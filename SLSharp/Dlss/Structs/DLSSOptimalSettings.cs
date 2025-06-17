using SLSharp.Structs;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Dlss.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DlssOptimalSettings
    {
        public DlssOptimalSettings()
        {
            baseStructure.StructType = new StructType(
            0xef1d0957, 0xfd58, 0x4df7, [0xb5, 0x4, 0x8b, 0x69, 0xd8, 0xaa, 0x6b, 0x76]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public readonly BaseStructure baseStructure;

        //! Specifies render area width
        public uint optimalRenderWidth = 0;
        //! Specifies render area height
        public uint optimalRenderHeight = 0;
        //! Specifies the optimal sharpness value
        public float optimalSharpness = 0.0f;
        //! Specifies minimal render area width
        public uint renderWidthMin = 0;
        //! Specifies minimal render area height
        public uint renderHeightMin = 0;
        //! Specifies maximal render area width
        public uint renderWidthMax = 0;
        //! Specifies maximal render area height
        public uint renderHeightMax = 0;
    }
}
