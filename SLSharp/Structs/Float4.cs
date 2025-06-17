using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Float4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public Float4()
        {
            x = Consts.INVALID_FLOAT;
            y = Consts.INVALID_FLOAT;
            z = Consts.INVALID_FLOAT;
            w = Consts.INVALID_FLOAT;
        }

        public Float4(float _x, float _y, float _z, float _w)
        {
            x = _x;
            y = _y;
            z = _z;
            w = _w;
        }
    }
}
