using System;
using System.Collections.Generic;
using System.Text;

namespace SLSharp.Enums
{
    public enum BufferType
    {
        /// <summary>Depth buffer - IMPORTANT - Must be suitable to use with clipToPrevClip transformation (see Constants below)</summary>
        kBufferTypeDepth = 0,

        /// <summary>Object and optional camera motion vectors (see Constants below)</summary>
        kBufferTypeMotionVectors = 1,

        /// <summary>Color buffer with all post-processing effects applied but without any UI/HUD elements</summary>
        kBufferTypeHUDLessColor = 2,

        /// <summary>Color buffer containing jittered input data for the image scaling pass</summary>
        kBufferTypeScalingInputColor = 3,

        /// <summary>Color buffer containing results from the image scaling pass</summary>
        kBufferTypeScalingOutputColor = 4,

        /// <summary>Normals</summary>
        kBufferTypeNormals = 5,

        /// <summary>Roughness</summary>
        kBufferTypeRoughness = 6,

        /// <summary>Albedo</summary>
        kBufferTypeAlbedo = 7,

        /// <summary>Specular Albedo</summary>
        kBufferTypeSpecularAlbedo = 8,

        /// <summary>Indirect Albedo</summary>
        kBufferTypeIndirectAlbedo = 9,

        /// <summary>Specular Motion Vectors</summary>
        kBufferTypeSpecularMotionVectors = 10,

        /// <summary>Disocclusion Mask</summary>
        kBufferTypeDisocclusionMask = 11,

        /// <summary>Emissive</summary>
        kBufferTypeEmissive = 12,

        /// <summary>Exposure</summary>
        kBufferTypeExposure = 13,

        /// <summary>Buffer with normal and roughness in alpha channel</summary>
        kBufferTypeNormalRoughness = 14,

        /// <summary>Diffuse and camera ray length</summary>
        kBufferTypeDiffuseHitNoisy = 15,

        /// <summary>Diffuse denoised</summary>
        kBufferTypeDiffuseHitDenoised = 16,

        /// <summary>Specular and reflected ray length</summary>
        kBufferTypeSpecularHitNoisy = 17,

        /// <summary>Specular denoised</summary>
        kBufferTypeSpecularHitDenoised = 18,

        /// <summary>Shadow noisy</summary>
        kBufferTypeShadowNoisy = 19,

        /// <summary>Shadow denoised</summary>
        kBufferTypeShadowDenoised = 20,

        /// <summary>AO noisy</summary>
        kBufferTypeAmbientOcclusionNoisy = 21,

        /// <summary>AO denoised</summary>
        kBufferTypeAmbientOcclusionDenoised = 22,

        /// <summary>
        /// Optional - UI/HUD color and alpha
        /// IMPORTANT: Please make sure that alpha channel has enough precision (for example do NOT use formats like R10G10B10A2)
        /// </summary>
        kBufferTypeUIColorAndAlpha = 23,

        /// <summary>Optional - Shadow pixels hint (set to 1 if a pixel belongs to the shadow area, 0 otherwise)</summary>
        kBufferTypeShadowHint = 24,

        /// <summary>Optional - Reflection pixels hint (set to 1 if a pixel belongs to the reflection area, 0 otherwise)</summary>
        kBufferTypeReflectionHint = 25,

        /// <summary>Optional - Particle pixels hint (set to 1 if a pixel represents a particle, 0 otherwise)</summary>
        kBufferTypeParticleHint = 26,

        /// <summary>Optional - Transparency pixels hint (set to 1 if a pixel belongs to the transparent area, 0 otherwise)</summary>
        kBufferTypeTransparencyHint = 27,

        /// <summary>Optional - Animated texture pixels hint (set to 1 if a pixel belongs to the animated texture area, 0 otherwise)</summary>
        kBufferTypeAnimatedTextureHint = 28,

        /// <summary>Optional - Bias for current color vs history hint - lerp(history, current, bias) (set to 1 to completely reject history)</summary>
        kBufferTypeBiasCurrentColorHint = 29,

        /// <summary>Optional - Ray-tracing distance (camera ray length)</summary>
        kBufferTypeRaytracingDistance = 30,

        /// <summary>Optional - Motion vectors for reflections</summary>
        kBufferTypeReflectionMotionVectors = 31,

        /// <summary>Optional - Position, in same space as eNormals</summary>
        kBufferTypePosition = 32,

        /// <summary>
        /// Optional - Indicates (via non-zero value) which pixels have motion/depth values that do not match the final color content at that pixel 
        /// (e.g. overlaid, opaque Picture-in-Picture)
        /// </summary>
        kBufferTypeInvalidDepthMotionHint = 33,

        /// <summary>Alpha</summary>
        kBufferTypeAlpha = 34,

        /// <summary>Color buffer containing only opaque geometry</summary>
        kBufferTypeOpaqueColor = 35,

        /// <summary>
        /// Optional - Reduce reliance on history instead using current frame hint (0 if a pixel is not at all reactive and default composition should be used,
        /// 1 if fully reactive)
        /// </summary>
        kBufferTypeReactiveMaskHint = 36,

        /// <summary>Optional - Pixel lock adjustment hint (set to 1 if pixel lock should be completely removed, 0 otherwise)</summary>
        kBufferTypeTransparencyAndCompositionMaskHint = 37,

        /// <summary>
        /// Optional - Albedo of the reflection ray hit point. For multibounce reflections, this should be the albedo of the first non-specular bounce.
        /// </summary>
        kBufferTypeReflectedAlbedo = 38,

        /// <summary>Optional - Color buffer before particles are drawn.</summary>
        kBufferTypeColorBeforeParticles = 39,

        /// <summary>Optional - Color buffer before transparent objects are drawn.</summary>
        kBufferTypeColorBeforeTransparency = 40,

        /// <summary>Optional - Color buffer before fog is drawn.</summary>
        kBufferTypeColorBeforeFog = 41,

        /// <summary>Optional - Buffer containing the hit distance of a specular ray.</summary>
        kBufferTypeSpecularHitDistance = 42,

        /// <summary>
        /// Optional - Buffer that contains 3 components of a specular ray direction, and 1 component of specular hit distance.
        /// </summary>
        kBufferTypeSpecularRayDirectionHitDistance = 43,

        /// <summary>Optional - Buffer containing normalized direction of a specular ray.</summary>
        kBufferTypeSpecularRayDirection = 44,

        /// <summary>Optional - Buffer containing the hit distance of a diffuse ray.</summary>
        kBufferTypeDiffuseHitDistance = 45,

        /// <summary>
        /// Optional - Buffer that contains 3 components of a diffuse ray direction, and 1 component of diffuse hit distance.
        /// </summary>
        kBufferTypeDiffuseRayDirectionHitDistance = 46,

        /// <summary>Optional - Buffer containing normalized direction of a diffuse ray.</summary>
        kBufferTypeDiffuseRayDirection = 47,

        /// <summary>Optional - Buffer containing display resolution depth.</summary>
        kBufferTypeHiResDepth = 48,

        /// <summary>Required either this or kBufferTypeDepth - Buffer containing linear depth.</summary>
        kBufferTypeLinearDepth = 49,

        /// <summary>
        /// Optional - Bidirectional distortion field. 4 channels in normalized [0,1] pixel space. 
        /// RG = distorted pixel to undistorted pixel displacement. 
        /// BA = undistorted pixel to distorted pixel displacement.
        /// </summary>
        kBufferTypeBidirectionalDistortionField = 50,

        /// <summary>
        /// Optional - Buffer containing particles or other similar transparent effects rendered into it instead of passing it as part of the input color
        /// </summary>
        kBufferTypeTransparencyLayer = 51,

        /// <summary>
        /// Optional - Buffer to be used in addition to TransparencyLayer which allows 3-channels of Opacity versus 1-channel. 
        /// TransparencyLayer represents Color (RcGcBc), TransparencyLayerOpacity represents alpha (RaGaBa)
        /// </summary>
        kBufferTypeTransparencyLayerOpacity = 52,

        /// <summary>Optional - Swapchain buffer to be presented</summary>
        kBufferTypeBackbuffer = 53,

        /// <summary>Optional - Mask for pixels to skip warping</summary>
        kBufferTypeNoWarpMask = 54,

        /// <summary>Optional - Color buffer after particles are drawn (for research purposes)</summary>
        kBufferTypeColorAfterParticles = 55,

        /// <summary>Optional - Color buffer after transparent objects are drawn (for research purposes)</summary>
        kBufferTypeColorAfterTransparency = 56,

        /// <summary>Optional - Color buffer after fog is drawn (for research purposes)</summary>
        kBufferTypeColorAfterFog = 57,

        /// <summary>Optional - Subsurface scattering guide buffer</summary>
        kBufferTypeScreenSpaceSubsurfaceScatteringGuide = 58,

        /// <summary>Optional - Color buffer before subsurface scattering (for research purposes)</summary>
        kBufferTypeColorBeforeScreenSpaceSubsurfaceScattering = 59,

        /// <summary>Optional - Color buffer after subsurface scattering (for research purposes)</summary>
        kBufferTypeColorAfterScreenSpaceSubsurfaceScattering = 60,

        /// <summary>Optional - Refraction guide buffer (for research purposes)</summary>
        kBufferTypeScreenSpaceRefractionGuide = 61,

        /// <summary>Optional - Color buffer before refraction (for research purposes)</summary>
        kBufferTypeColorBeforeScreenSpaceRefraction = 62,

        /// <summary>Optional - Color buffer after refraction (for research purposes)</summary>
        kBufferTypeColorAfterScreenSpaceRefraction = 63,

        /// <summary>Optional - Depth of Field Buffer (for research purposes)</summary>
        kBufferTypeDepthOfFieldGuide = 64,

        /// <summary>Optional - Color buffer before Depth of Field (for research purposes)</summary>
        kBufferTypeColorBeforeDepthOfField = 65,

        /// <summary>Optional - Color buffer after Depth of Field (for research purposes)</summary>
        kBufferTypeColorAfterDepthOfField = 66,

        /// <summary>Optional - Color buffer that overrides the alpha channel of kBufferTypeScalingOutputColor</summary>
        kBufferTypeScalingOutputAlpha = 67
    }
}
