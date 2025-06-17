using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PrecisionInfo
    {
        public enum PrecisionFormula : uint
        {
            eNoTransform = 0,           // hi = lo, essentially no conversion is done
            eLinearTransform,           // hi = lo * scale + bias
        }

        public PrecisionInfo()
        {
            baseStructure.StructType = new StructType(
            0x98f6e9ba, 0x8d16, 0x4831, [0xa8, 0x2, 0x4d, 0x3b, 0x52, 0xff, 0x26, 0xbf]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public unsafe PrecisionInfo(PrecisionFormula formula, float bias, float scale)
        {
            baseStructure.StructType = new StructType(
            0x98f6e9ba, 0x8d16, 0x4831, [0xa8, 0x2, 0x4d, 0x3b, 0x52, 0xff, 0x26, 0xbf]);
            baseStructure.StructVersion = Consts.kStructVersion1;


        }

        public readonly BaseStructure baseStructure;

        PrecisionFormula conversionFormula = PrecisionFormula.eNoTransform;
        public float bias = 0.0f;
        public float scale = 1.0f;

        public static bool operator ==(PrecisionInfo lhs, PrecisionInfo rhs)
        {
            return lhs.conversionFormula == rhs.conversionFormula && lhs.bias == rhs.bias && lhs.scale == rhs.scale;
        }

        public static bool operator !=(PrecisionInfo lhs, PrecisionInfo rhs)
        {
            return lhs != rhs;
        }
    }
}
