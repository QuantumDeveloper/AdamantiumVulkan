// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Core;

public enum Result : int
{
    Success = 0,

    NotReady = 1,

    Timeout = 2,

    EventSet = 3,

    EventReset = 4,

    Incomplete = 5,

    ErrorOutOfHostMemory = -1,

    ErrorOutOfDeviceMemory = -2,

    ErrorInitializationFailed = -3,

    ErrorDeviceLost = -4,

    ErrorMemoryMapFailed = -5,

    ErrorLayerNotPresent = -6,

    ErrorExtensionNotPresent = -7,

    ErrorFeatureNotPresent = -8,

    ErrorIncompatibleDriver = -9,

    ErrorTooManyObjects = -10,

    ErrorFormatNotSupported = -11,

    ErrorFragmentedPool = -12,

    ErrorUnknown = -13,

    ErrorOutOfPoolMemory = -1000069000,

    ErrorInvalidExternalHandle = -1000072003,

    ErrorFragmentation = -1000161000,

    ErrorInvalidOpaqueCaptureAddress = -1000257000,

    PipelineCompileRequired = 1000297000,

    ErrorSurfaceLostKhr = -1000000000,

    ErrorNativeWindowInUseKhr = -1000000001,

    SuboptimalKhr = 1000001003,

    ErrorOutOfDateKhr = -1000001004,

    ErrorIncompatibleDisplayKhr = -1000003001,

    ErrorValidationFailedExt = -1000011001,

    ErrorInvalidShaderNv = -1000012000,

    ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,

    ErrorNotPermittedKhr = -1000174001,

    ErrorFullScreenExclusiveModeLostExt = -1000255000,

    ThreadIdleKhr = 1000268000,

    ThreadDoneKhr = 1000268001,

    OperationDeferredKhr = 1000268002,

    OperationNotDeferredKhr = 1000268003,

    ErrorCompressionExhaustedExt = -1000338000,

    ResultMaxEnum = 2147483647,

}



