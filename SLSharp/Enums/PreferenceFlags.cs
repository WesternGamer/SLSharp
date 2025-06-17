using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Enums
{
    public enum PreferenceFlags : ulong
    {
        //! Set by default - Disables command list state tracking - Host application is responsible for restoring CL state correctly after each 'slEvaluateFeature' call
        eDisableCLStateTracking = 1 << 0,
        //! Optional - Disables debug text on screen in development builds
        eDisableDebugText = 1 << 1,
        //! Optional - IMPORTANT: Only to be used in the advanced integration mode, see the 'manual hooking' programming guide for more details
        eUseManualHooking = 1 << 2,
        //! Optional - Enables downloading of Over The Air (OTA) updates for SL and NGX
        //! This will invoke the OTA updater to look for new updates. A separate
        //! flag below is used to control whether or not OTA-downloaded SL Plugins are
        //! loaded.
        eAllowOTA = 1 << 3,
        //! Do not check OS version when deciding if feature is supported or not
        //! 
        //! IMPORTANT: ONLY SET THIS FLAG IF YOU KNOW WHAT YOU ARE DOING. 
        //! 
        //! VARIOUS WIN APIs INCLUDING BUT NOT LIMITED TO `IsWindowsXXX`, `GetVersionX`, `rtlGetVersion` ARE KNOWN FOR RETURNING INCORRECT RESULTS.
        eBypassOSVersionCheck = 1 << 4,
        //! Optional - If specified SL will create DXGI factory proxy rather than modifying the v-table for the base interface.
        //! 
        //! This can help with 3rd party overlays which are NOT integrated with the host application but rather operate via injection.
        eUseDXGIFactoryProxy = 1 << 5,
        //! Optional - Enables loading of plugins downloaded Over The Air (OTA), to
        //! be used in conjunction with the eAllowOTA flag.
        eLoadDownloadedPlugins = 1 << 6,

        //! Optional - allow tagging of resources for frame. This helps distinguish whether slEvaluateFeature needs to do frame-based tagging
        //! of resources which wasn't the case earlier.
        eUseFrameBasedResourceTagging = 1 << 7,
};
}
