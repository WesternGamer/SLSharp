using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Float3
    {
        public float x;
        public float y;
        public float z;

        public Float3()
        {
            x = Consts.INVALID_FLOAT;
            y = Consts.INVALID_FLOAT;
            z = Consts.INVALID_FLOAT;
        }

        public Float3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }

}
