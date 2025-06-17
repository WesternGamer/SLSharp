using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Float2
    {
        public float x;
        public float y; 

        public Float2()
        {
            x = Consts.INVALID_FLOAT;
            y = Consts.INVALID_FLOAT;
        }

        public Float2(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
    }
}
