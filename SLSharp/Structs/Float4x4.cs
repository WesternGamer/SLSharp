
using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Float4x4
    {
        // Row-major 4x4 matrix represented as an array of Float4
        private Float4 row0;
        private Float4 row1;
        private Float4 row2;
        private Float4 row3;

        public Float4 this[int i]
        {
            get => i switch
            {
                0 => row0,
                1 => row1,
                2 => row2,
                3 => row3,
                _ => throw new IndexOutOfRangeException("Matrix row index must be 0–3.")
            };
            set
            {
                switch (i)
                {
                    case 0: row0 = value; break;
                    case 1: row1 = value; break;
                    case 2: row2 = value; break;
                    case 3: row3 = value; break;
                    default: throw new IndexOutOfRangeException("Matrix row index must be 0–3.");
                }
            }
        }

        public void SetRow(int i, Float4 v) => this[i] = v;
        public Float4 GetRow(int i) => this[i];
    }
}
