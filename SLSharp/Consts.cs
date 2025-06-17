namespace SLSharp
{
    public static class Consts
    {
        public const uint kStructVersion1 = 1;
        public const uint kStructVersion2 = 2;
        public const uint kStructVersion3 = 3;

        public const float INVALID_FLOAT = 3.40282346638528859811704183484516925440e38f;
        public const uint INVALID_UINT = 0xffffffff;

        public const uint MAX_FRAMES_IN_FLIGHT = 6;

        public const uint SL_VERSION_MAJOR = 2;
        public const uint SL_VERSION_MINOR = 7;
        public const uint SL_VERSION_PATCH = 32;

        public const ulong kSDKVersionMagic = 0xfedc;

        public static readonly ulong kSDKVersion = (SL_VERSION_MAJOR << 48) | (SL_VERSION_MINOR << 32) | (SL_VERSION_PATCH << 16) | kSDKVersionMagic;
    }
}
