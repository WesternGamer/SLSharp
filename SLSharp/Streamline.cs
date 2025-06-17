using SLSharp.Enums;
using SLSharp.Structs;
using System.Runtime.InteropServices;

namespace SLSharp
{
    public static class Streamline
    {
        //! Initializes the SL module
        //!
        //! Call this method when the game is initializing. 
        //!
        //! @param pref Specifies preferred behavior for the SL library (SL will keep a copy)
        //! @param sdkVersion Current SDK version
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe.
        [DllImport("sl.interposer.dll")]
        public static extern Result slInit(ref Preferences pref, ulong sdkVersion);

        //! Shuts down the SL module
        //!
        //! Call this method when the game is shutting down. 
        //!
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe.
        [DllImport("sl.interposer.dll")]
        public static extern Result slShutdown();

        //! Checks if a specific feature is supported or not.
        //!
        //! Call this method to check if a certain e* (see above) is available.
        //!
        //! @param feature Specifies which feature to use
        //! @param adapterInfo Adapter to check (optional)
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! NOTE: If adapter info is null SL will return general feature compatibility with the OS,
        //! installed drivers or any other requirements not directly related to the adapter.
        //! 
        //! This method is NOT thread safe.
        [DllImport("sl.interposer.dll")]
        public static extern Result slIsFeatureSupported(Feature feature, ref AdapterInfo adapterInfo);

        //! Checks if specified feature is loaded or not.
        //!
        //! Call this method to check if feature is loaded.
        //! All requested features are loaded by default and have to be unloaded explicitly if needed.
        //!
        //! @param feature Specifies which feature to check
        //! @param loaded Value specifying if feature is loaded or unloaded.
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe and requires DX/VK device to be created before calling it.
        [DllImport("sl.interposer.dll")]
        public static extern Result slIsFeatureLoaded(Feature feature, ref bool loaded);

        //! Sets the specified feature to either loaded or unloaded state.
        //!
        //! Call this method to load or unload certain e*. 
        //!
        //! NOTE: All requested features are loaded by default and have to be unloaded explicitly if needed.
        //!
        //! @param feature Specifies which feature to check
        //! @param loaded Value specifying if feature should be loaded or unloaded.
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! NOTE: When this method is called no other DXGI/D3D/Vulkan APIs should be invoked in parallel so
        //! make sure to flush your pipeline before calling this method.
        //!
        //! This method is NOT thread safe and requires DX/VK device to be created before calling it.
        [DllImport("sl.interposer.dll")]
        public static extern Result slSetFeatureLoaded(Feature feature, bool loaded);

        // slSetTagForFrame

        // slSetTag

        //! Sets common constants.
        //!
        //! Call this method to provide the required data (SL will keep a copy).
        //!
        //! @param values Common constants required by SL plugins (SL will keep a copy)
        //! @param frame Index of the current frame
        //! @param viewport Unique id (can be viewport id | instance id etc.)
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //! 
        //! This method is thread safe and requires DX/VK device to be created before calling it.
        [DllImport("sl.interposer.dll")]
        public static extern Result slSetConstants(ref Constants values, IntPtr frame, ref ViewportHandle viewport);

        //! Returns feature's requirements
        //!
        //! Call this method to check what is required to run certain eFeature* (see above).
        //! This method must be called after init otherwise it will always return an error.
        //!
        //! @param feature Specifies which feature to check
        //! @param requirements Data structure with feature's requirements
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe.
        [DllImport("sl.interposer.dll")]
        public static extern Result slGetFeatureRequirements(Feature feature, ref FeatureRequirements requirements);

        //! Returns feature's version
        //!
        //! Call this method to check version for a certain eFeature* (see above).
        //! This method must be called after init otherwise it will always return an error.
        //!
        //! @param feature Specifies which feature to check
        //! @param version Data structure with feature's version
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is thread safe.
        [DllImport("sl.interposer.dll")]
        public static extern Result slGetFeatureVersion(Feature feature, ref FeatureVersion version);

        //! Allocates resources for the specified feature.
        //!
        //! Call this method to explicitly allocate resources
        //! for an instance of the specified feature.
        //! 
        //! @param cmdBuffer Command buffer to use (must be created on device where feature is supported but can be null if not needed)
        //! @param feature Feature we are working with
        //! @param viewport Unique id (viewport handle)
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe and requires DX/VK device to be created before calling it.
        [DllImport("sl.interposer.dll")]
        public static extern Result slAllocateResources(IntPtr cmdBuffer, Feature feature, ref ViewportHandle viewport);

        //! Frees resources for the specified feature.
        //!
        //! Call this method to explicitly free resources
        //! for an instance of the specified feature.
        //! 
        //! @param feature Feature we are working with
        //! @param viewport Unique id (viewport handle)
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! IMPORTANT: If slEvaluateFeature is pending on a command list, that command list must be flushed
        //! before calling this method to prevent invalid resource access on the GPU.
        //!
        //! IMPORTANT: If slEvaluateFeature is pending on a command list, that command list must be flushed
        //! before calling this method to prevent invalid resource access on the GPU.
        //!
        //! This method is NOT thread safe and requires DX/VK device to be created before calling it.
        [DllImport("sl.interposer.dll")]
        public static extern Result slFreeResources(Feature feature, ref ViewportHandle viewport);

        // slEvaluateFeature

        //! Upgrade interface
        //! 
        //! Use this method to upgrade basic D3D or DXGI interface to an SL proxy.
        //! 
        //! @param baseInterface Pointer to a pointer to the base interface (for example ID3D12Device etc.) to be replaced in place.
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //! 
        //! IMPORTANT: This method should ONLY be used to support 3rd party SDKs like AMD AGS
        //! which bypass SL or when using manual hooking.
        //!
        //! This method is NOT thread safe and should be called IMMEDIATELY after base interface is created.
        [DllImport("sl.interposer.dll")]
        public static extern Result slUpgradeInterface(ref IntPtr baseInterface);

        //! Obtain native interface
        //! 
        //! Use this method to obtain underlying D3D or DXGI interface from an SL proxy.
        //! 
        //! IMPORTANT: When calling NVAPI or other 3rd party SDKs from your application 
        //! it is recommended to provide native interfaces instead of SL proxies.
        //! 
        //! @param proxyInterface Pointer to the SL proxy (D3D device, swap-chain etc)
        //! @param baseInterface Pointer to a pointer to the base interface be returned.
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //! 
        //! This method is NOT thread safe
        [DllImport("sl.interposer.dll")]
        public static extern Result slGetNativeInterface(IntPtr proxyInterface, ref IntPtr baseInterface);

        //! Gets specific feature's function
        //!
        //! Call this method to obtain various functions for the specified feature. See sl_$feature.h for details.
        //!
        //! @param feature Feature we are working with
        //! @param functionName The name of the API to obtain (declared in sl_[$feature].h
        //! @param function Pointer to the function to return
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //! 
        //! IMPORTANT: Must be called AFTER device is set by calling either slSetD3DDevice or slSetVulkanInfo.
        //!
        //! This method is thread safe.
        [DllImport("sl.interposer.dll")]
        public static extern Result slGetFeatureFunction(Feature feature, string functionName, ref IntPtr function);

        //! Gets unique frame token
        //!
        //! Call this method to obtain token for the unique frame identification.
        //!
        //! @param handle Frame token to return
        //! @param frameIndex Frame index (optional, if not provided SL internal frame counting is used)
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //! 
        //! NOTE: Normally SL would not expect more that 3 frames in flight due to added latency.
        //!
        //! This method is thread safe.
        [DllImport("sl.interposer.dll")]
        public static extern Result slGetNewFrameToken(ref IntPtr token, ref uint frameIndex);

        //! Set D3D device to use
        //! 
        //! Use this method to specify which D3D device should be used.
        //! 
        //! @param d3dDevice D3D device to use
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe and should be called IMMEDIATELY after main device is created.
        [DllImport("sl.interposer.dll")]
        public static extern Result slSetD3DDevice(IntPtr d3dDevice);
    }
}
