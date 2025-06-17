using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Enums
{
    public enum FeatureRequirementFlags : uint
    {
        //! Rendering APIs
        eD3D11Supported = 1 << 0,
        eD3D12Supported = 1 << 1,
        eVulkanSupported = 1 << 2,
        //! If set V-Sync must be disabled when feature is active
        eVSyncOffRequired = 1 << 3,
        //! If set GPU hardware scheduling OS feature must be turned on
        eHardwareSchedulingRequired = 1 << 4
    }
}
