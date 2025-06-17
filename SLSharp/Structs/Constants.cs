using System.Runtime.InteropServices;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Constants 
    {
        public Constants()
        {
            baseStructure.StructType = new StructType(
            0xdcd35ad7, 0x4e4a, 0x4bad, [0xa9, 0x0c, 0xe0, 0xc4, 0x9e, 0xb2, 0x3a, 0xfe]);
            baseStructure.StructVersion = Consts.kStructVersion2;
        }

        public readonly BaseStructure baseStructure;

        public Float4x4 cameraViewToClip;
        public Float4x4 clipToCameraView;
        public Float4x4 clipToLensClip;
        public Float4x4 clipToPrevClip;
        public Float4x4 prevClipToClip;

        public Float2 jitterOffset;
        public Float2 mvecScale;
        public Float2 cameraPinholeOffset;

        public Float3 cameraPos;
        public Float3 cameraUp;
        public Float3 cameraRight;
        public Float3 cameraFwd;

        public float cameraNear = Consts.INVALID_FLOAT;
        public float cameraFar = Consts.INVALID_FLOAT;
        public float cameraFOV = Consts.INVALID_FLOAT;
        public float cameraAspectRatio = Consts.INVALID_FLOAT;
        public float motionVectorsInvalidValue = Consts.INVALID_FLOAT;

        public Enums.Boolean depthInverted = Enums.Boolean.eInvalid;
        public Enums.Boolean cameraMotionIncluded = Enums.Boolean.eInvalid;
        public Enums.Boolean motionVectors3D = Enums.Boolean.eInvalid;
        public Enums.Boolean reset = Enums.Boolean.eInvalid;
        public Enums.Boolean orthographicProjection = Enums.Boolean.eFalse;
        public Enums.Boolean motionVectorsDilated = Enums.Boolean.eFalse;
        public Enums.Boolean motionVectorsJittered = Enums.Boolean.eFalse;

        public float minRelativeLinearDepthObjectSeparation = 40.0f;
    }
}
