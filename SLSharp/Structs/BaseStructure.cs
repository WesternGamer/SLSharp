using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BaseStructure
    {
        public IntPtr Next;
        public StructType StructType;
        public ulong StructVersion;

        public BaseStructure(StructType type, ulong version)
        {
            Next = IntPtr.Zero;
            StructType = type;
            StructVersion = version;
        }
    }
}
