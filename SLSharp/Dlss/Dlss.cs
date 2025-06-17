using SLSharp.Dlss.Structs;
using SLSharp.Enums;
using SLSharp.Structs;
using System.Runtime.InteropServices;

namespace SLSharp.Dlss
{
    public static class Dlss
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate Result PFun_slDLSSGetOptimalSettings(ref DlssOptions options, ref DlssOptimalSettings settings);
        private static IntPtr s_slDLSSGetOptimalSettings;

        //! Provides optimal DLSS settings
        //!
        //! Call this method to obtain optimal render target size and other DLSS related settings.
        //!
        //! @param options Specifies DLSS options to use
        //! @param settings Reference to a structure where settings are returned
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe.
        public static Result slDLSSGetOptimalSettings(ref DlssOptions options, ref DlssOptimalSettings settings)
        {
            if (s_slDLSSGetOptimalSettings == IntPtr.Zero) 
            {
                Result res = Streamline.slGetFeatureFunction(Feature.kFeatureDLSS, "slDLSSGetOptimalSettings", ref s_slDLSSGetOptimalSettings);

                if (res != Result.eOk)
                {
                    return res;
                }
            }

            return Marshal.GetDelegateForFunctionPointer<PFun_slDLSSGetOptimalSettings>(s_slDLSSGetOptimalSettings).Invoke(ref options, ref settings);
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate Result PFun_slDLSSGetState(ref ViewportHandle viewport, ref DlssState state);
        private static IntPtr s_slDLSSGetState;
        //! Provides DLSS state for the given viewport
        //!
        //! Call this method to obtain optimal render target size and other DLSS related settings.
        //!
        //! @param viewport Specified viewport we are working with
        //! @param state Reference to a structure where state is to be returned
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe.
        public static Result slDLSSGetState(ref ViewportHandle viewport, ref DlssState state)
        {
            if (s_slDLSSGetState == IntPtr.Zero)
            {
                Result res = Streamline.slGetFeatureFunction(Feature.kFeatureDLSS, "slDLSSGetState", ref s_slDLSSGetState);

                if (res != Result.eOk)
                {
                    return res;
                }
            }

            return Marshal.GetDelegateForFunctionPointer<PFun_slDLSSGetState>(s_slDLSSGetState).Invoke(ref viewport, ref state);
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate Result PFun_slDLSSSetOptions(ref ViewportHandle viewport, ref DlssOptions options);
        private static IntPtr s_slDLSSSetOptions;
        //! Sets DLSS options
        //!
        //! Call this method to turn DLSS on/off, change mode etc.
        //!
        //! @param viewport Specified viewport we are working with
        //! @param options Specifies DLSS options to use
        //! @return sl::ResultCode::eOk if successful, error code otherwise (see sl_result.h for details)
        //!
        //! This method is NOT thread safe.
        public static Result slDLSSSetOptions(ref ViewportHandle viewport, ref DlssOptions options)
        {
            if (s_slDLSSSetOptions == IntPtr.Zero)
            {
                Result res = Streamline.slGetFeatureFunction(Feature.kFeatureDLSS, "slDLSSSetOptions", ref s_slDLSSSetOptions);

                if (res != Result.eOk)
                {
                    return res;
                }
            }

            return Marshal.GetDelegateForFunctionPointer<PFun_slDLSSSetOptions>(s_slDLSSSetOptions).Invoke(ref viewport, ref options);
        }
    }
}
