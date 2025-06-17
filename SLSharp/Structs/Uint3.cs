using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct UInt3
    {
        public uint x;
        public uint y;
        public uint z;
    }
}
