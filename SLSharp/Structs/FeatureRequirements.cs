using SLSharp.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SLSharp.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FeatureRequirements
    {
        public FeatureRequirements()
        {
            baseStructure.StructType = new StructType(
            0x66714097, 0xac6d, 0x4bc6, [0x89, 0x15, 0x1e, 0xf, 0x55, 0xa6, 0xb6, 0x1f]);
            baseStructure.StructVersion = Consts.kStructVersion2;
        }

        public readonly BaseStructure baseStructure;

        //! Various Flags
        public FeatureRequirementFlags flags = 0;

        //! Feature will create this many CPU threads
        public uint maxNumCPUThreads = 0;

        //! Feature supports only this many viewports
        public uint maxNumViewports = 0;

        //! Required buffer tags
        public uint numRequiredTags = 0;
        IntPtr requiredTags = IntPtr.Zero;

        //! OS and Driver versions
        public Version osVersionDetected = new Version();
        public Version osVersionRequired = new Version();
        public Version driverVersionDetected = new Version();
        public Version driverVersionRequired = new Version();

        //! Vulkan specific bits

        //! Command queues
        public uint vkNumComputeQueuesRequired = 0;
        public uint vkNumGraphicsQueuesRequired = 0;

        //! Device extensions
        public uint vkNumDeviceExtensions = 0;
        IntPtr vkDeviceExtensions = IntPtr.Zero;
        //! Instance extensions
        public uint vkNumInstanceExtensions = 0;
        public IntPtr vkInstanceExtensions = IntPtr.Zero;
        //! 1.2 features
        //! 
        //! NOTE: Use getVkPhysicalDeviceVulkan12Features from sl_helpers_vk.h
        public uint vkNumFeatures12 = 0;
        public IntPtr vkFeatures12 = IntPtr.Zero;
        //! 1.3 features
        //! 
        //! NOTE: Use getVkPhysicalDeviceVulkan13Features from sl_helpers_vk.h
        public uint vkNumFeatures13 = 0;
        public IntPtr vkFeatures13 = IntPtr.Zero;

        //! Vulkan optical flow feature
        public uint vkNumOpticalFlowQueuesRequired = 0;
    }
}
