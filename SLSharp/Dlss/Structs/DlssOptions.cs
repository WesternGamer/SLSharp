using SLSharp.Dlss.Enums;
using SLSharp.Structs;
using System.Runtime.InteropServices;

namespace SLSharp.Dlss.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DlssOptions
    {
        public DlssOptions()
        {
            baseStructure.StructType = new StructType(
            0x6ac826e4, 0x4c61, 0x4101, [0xa9, 0x2d, 0x63, 0x8d, 0x42, 0x10, 0x57, 0xb8]);
            baseStructure.StructVersion = Consts.kStructVersion3;
        }

        public readonly BaseStructure baseStructure;

        //! Specifies which mode should be used
        public DlssMode mode = DlssMode.eOff;
        //! Specifies output (final) target width
        public uint outputWidth = Consts.INVALID_UINT;
        //! Specifies output (final) target height
        public uint outputHeight = Consts.INVALID_UINT;
        //! Specifies sharpening level in range [0,1]
        public float sharpness = 0.0f;
        //! Specifies pre-exposure value
        public float preExposure = 1.0f;
        //! Specifies exposure scale value
        public float exposureScale = 1.0f;
        //! Specifies if tagged color buffers are full HDR or not (DLSS in HDR pipeline or not)
        public SLSharp.Enums.Boolean colorBuffersHDR = SLSharp.Enums.Boolean.eTrue;
        //! Specifies if indicator on screen should invert axis
        public SLSharp.Enums.Boolean indicatorInvertAxisX = SLSharp.Enums.Boolean.eFalse;
        //! Specifies if indicator on screen should invert axis
        public SLSharp.Enums.Boolean indicatorInvertAxisY = SLSharp.Enums.Boolean.eFalse;
        //! Presets
        public DlssPreset dlaaPreset = DlssPreset.eDefault;
        public DlssPreset qualityPreset = DlssPreset.eDefault;
        public DlssPreset balancedPreset = DlssPreset.eDefault;
        public DlssPreset performancePreset = DlssPreset.eDefault;
        public DlssPreset ultraPerformancePreset = DlssPreset.eDefault;
        public DlssPreset ultraQualityPreset = DlssPreset.eDefault;

        //! Specifies if the setting for AutoExposure is used
        public SLSharp.Enums.Boolean useAutoExposure = SLSharp.Enums.Boolean.eFalse;

        //! Whether or not the alpha channel should be upscaled (if false, only RGB is upscaled)
        //! Enabling alpha upscaling may impact performance
        public SLSharp.Enums.Boolean alphaUpscalingEnabled = SLSharp.Enums.Boolean.eFalse;
    }
}
