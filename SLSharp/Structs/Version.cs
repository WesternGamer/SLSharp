using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Structs
{
    public struct Version : IEquatable<Version>, IComparable<Version>
    {
        public uint Major = 0;
        public uint Minor = 0;
        public uint Build = 0;

        public Version(uint major = 0, uint minor = 0, uint build = 0)
        {
            Major = major;
            Minor = minor;
            Build = build;
        }

        public static implicit operator bool(Version v) =>
            v.Major != 0 || v.Minor != 0 || v.Build != 0;

        public override string ToString() =>
            $"{Major}.{Minor}.{Build}";

        public string ToWStr() =>
            $"{Major}.{Minor}.{Build}";  // In C#, string is Unicode by default

        public string ToWStrOTAId() =>
            ((Major << 16) | (Minor << 8) | Build).ToString();

        public bool Equals(Version other) =>
            Major == other.Major && Minor == other.Minor && Build == other.Build;

        public override bool Equals(object obj) =>
            obj is Version other && Equals(other);

        public int CompareTo(Version other)
        {
            if (Major != other.Major)
                return Major.CompareTo(other.Major);
            if (Minor != other.Minor)
                return Minor.CompareTo(other.Minor);
            return Build.CompareTo(other.Build);
        }

        public static bool operator ==(Version left, Version right) =>
            left.Equals(right);

        public static bool operator !=(Version left, Version right) =>
            !left.Equals(right);

        public static bool operator >(Version left, Version right) =>
            left.CompareTo(right) > 0;

        public static bool operator >=(Version left, Version right) =>
            left.CompareTo(right) >= 0;

        public static bool operator <(Version left, Version right) =>
            left.CompareTo(right) < 0;

        public static bool operator <=(Version left, Version right) =>
            left.CompareTo(right) <= 0;
    }
}
