using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FeatureVersion
    {
        public FeatureVersion()
        {
            baseStructure.StructType = new StructType(
            0x677315f, 0xa746, 0x4492, [0x9f, 0x42, 0xcb, 0x61, 0x42, 0xc9, 0xc3, 0xd4]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public readonly BaseStructure baseStructure;

        //! SL version
        public Version versionSL = new Version();
        //! NGX version (if feature is using NGX, null otherwise)
        public Version versionNGX = new Version();
    }
}
