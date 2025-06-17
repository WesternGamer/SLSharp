using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Extent
    {
        public uint top = 0;
        public uint left = 0;
        public uint width = 0;
        public uint height = 0;

        public Extent()
        {
        }

        // Implicit conversion to bool in C++ → use property in C#
        public bool IsValid => width != 0 && height != 0;

        // Equality
        public bool Equals(Extent other)
        {
            return top == other.top &&
                   left == other.left &&
                   width == other.width &&
                   height == other.height;
        }

        public override bool Equals(object obj) => obj is Extent other && Equals(other);

        public static bool operator ==(Extent lhs, Extent rhs) => lhs.Equals(rhs);
        public static bool operator !=(Extent lhs, Extent rhs) => !lhs.Equals(rhs);

        // Custom method
        public bool IsSameResolution(Extent other)
        {
            return width == other.width && height == other.height;
        }
    }
}
