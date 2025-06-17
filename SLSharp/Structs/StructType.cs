using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct StructType
    {
        public uint data1;
        public ushort data2;
        public ushort data3;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] data4;

        public StructType(uint data1, ushort data2, ushort data3, byte[] data4)
        {
            this.data1 = data1;
            this.data2 = data2;
            this.data3 = data3;
            this.data4 = data4;
        }

        public bool Equals(StructType other)
        {
            if (data1 != other.data1 || data2 != other.data2 || data3 != other.data3)
                return false;

            if (data4 == null || other.data4 == null || data4.Length != other.data4.Length)
                return false;

            for (int i = 0; i < data4.Length; i++)
            {
                if (data4[i] != other.data4[i])
                    return false;
            }

            return true;
        }

        public override bool Equals(object obj) => obj is StructType other && Equals(other);
        public static bool operator ==(StructType left, StructType right) => left.Equals(right);
        public static bool operator !=(StructType left, StructType right) => !(left == right);
    }
}
