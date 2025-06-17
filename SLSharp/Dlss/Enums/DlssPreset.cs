using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Dlss.Enums
{
    public enum DlssPreset : uint
    {
        //! Default behavior, may or may not change after an OTA
        eDefault,
        //! Fixed DL models
        ePresetA,   // Intended for Perf/Balanced/Quality modes. An older variant best suited to combat ghosting for elements with missing inputs (such as motion vectors)
        ePresetB,   // Intended for Ultra Perf mode. Similar to Preset A but for Ultra Performance mode
        ePresetC,   // Intended for Perf/Balanced/Quality modes. Preset which generally favors current frame information. Generally well-suited for fast-paced game content
        ePresetD,   // Intended for Perf/Balanced/Quality modes. Similar to Preset E. Preset E is generally recommended over Preset D
        ePresetE,   // Intended for Perf/Balanced/Quality modes. Preset for most performance and image stability
        ePresetF,   // Intended for Ultra Perf/DLAA modes. The default preset for Ultra Perf and DLAA modes
        ePresetG,   // Reverts to default, not recommended to use
        ePresetH,   // Reverts to default, not recommended to use
        ePresetI,   // Reverts to default, not recommended to use
        ePresetJ,   // Similar to preset K. Preset J might exhibit slightly less ghosting at the cost of extra flickering. Preset K is generally recommended over preset J
        ePresetK,   // Default preset for DLAA/Perf/Balanced/Quality modes that is transformer based. Best image quality preset at a higher performance cost
        ePresetL,   // Reverts to default, not recommended to use
        ePresetM,   // Reverts to default, not recommended to use
        ePresetN,   // Reverts to default, not recommended to use
        ePresetO,   // Reverts to default, not recommended to use

        eCount
    }
}
