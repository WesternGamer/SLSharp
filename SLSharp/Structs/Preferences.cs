using SLSharp.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Preferences
    {
        public Preferences()
        {
            baseStructure.StructType = new StructType(
            0x1ca10965, 0xbf8e, 0x432b, [0x8d, 0xa1, 0x67, 0x16, 0xd8, 0x79, 0xfb, 0x14]);
            baseStructure.StructVersion = Consts.kStructVersion1;
        }

        public readonly BaseStructure baseStructure;

        //! Optional - In non-production builds it is useful to enable debugging console window
        public bool showConsole = false;
        //! Optional - Various logging levels
        public LogLevel logLevel = LogLevel.eDefault;
        //! Optional - Absolute paths to locations where to look for plugins, first path in the list has the highest priority
        public IntPtr pathsToPlugins = IntPtr.Zero;
        //! Optional - Number of paths to search
        public uint numPathsToPlugins = 0;
        //! Optional - Absolute path to location where logs and other data should be stored
        //! 
        //! NOTE: Set this to nullptr in order to disable logging to a file
        public IntPtr pathToLogsAndData = IntPtr.Zero;
        //! Optional - Allows resource allocation tracking on the host side
        public IntPtr allocateCallback = IntPtr.Zero;
        //! Optional - Allows resource deallocation tracking on the host side
        public IntPtr releaseCallback = IntPtr.Zero;
        //! Optional - Allows log message tracking including critical errors if they occur
        public IntPtr logMessageCallback = IntPtr.Zero;
        //! Optional - Flags used to enable or disable advanced options
        public PreferenceFlags flags = PreferenceFlags.eDisableCLStateTracking | PreferenceFlags.eAllowOTA | PreferenceFlags.eLoadDownloadedPlugins;
        //! Required - Features to load (assuming appropriate plugins are found), if not specified NO features will be loaded by default
        public IntPtr featuresToLoad = IntPtr.Zero;
        //! Required - Number of features to load, only used when list is not a null pointer
        public uint numFeaturesToLoad = 0;
        //! Optional - Id provided by NVIDIA, if not specified then engine type and version are required
        public uint applicationId = 0;
        //! Optional - Type of the rendering engine used, if not specified then applicationId is required
        public EngineType engine = EngineType.eCustom;
        //! Optional - Version of the rendering engine used
        [MarshalAs(UnmanagedType.LPStr)]
        public string engineVersion;
        //! Optional - GUID (like for example 'a0f57b54-1daf-4934-90ae-c4035c19df04')
        [MarshalAs(UnmanagedType.LPStr)]
        public string projectId;
        //! Optional - Which rendering API host is planning to use
        //! 
        //! NOTE: To ensure correct `slGetFeatureRequirements` behavior please specify if planning to use Vulkan.
        public RenderAPI renderAPI = RenderAPI.eD3D12;
    }
}
