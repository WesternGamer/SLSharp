using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Enums
{
    public enum Feature : uint
    {
        /// <summary>Deep Learning Super Sampling</summary>
        kFeatureDLSS = 0,

        /// <summary>Real-Time Denoiser (removed)</summary>
        kFeatureNRD_INVALID = 1,

        /// <summary>NVIDIA Image Scaling</summary>
        kFeatureNIS = 2,

        /// <summary>Reflex</summary>
        kFeatureReflex = 3,

        /// <summary>PC Latency</summary>
        kFeaturePCL = 4,

        /// <summary>DeepDVC</summary>
        kFeatureDeepDVC = 5,

        /// <summary>Latewarp</summary>
        kFeatureLatewarp = 6,

        /// <summary>DLSS Frame Generation</summary>
        kFeatureDLSS_G = 1000,

        /// <summary>DLSS Ray Reconstruction</summary>
        kFeatureDLSS_RR = 1001,

        /// <summary>NvPerf</summary>
        kFeatureNvPerf = 1002,

        /// <summary>DirectSR</summary>
        kFeatureDirectSR = 1003,

        /// <summary>ImGUI</summary>
        kFeatureImGUI = 9999,

        /// <summary>Common feature, NOT intended to be used directly</summary>
        kFeatureCommon = uint.MaxValue
    }
}
