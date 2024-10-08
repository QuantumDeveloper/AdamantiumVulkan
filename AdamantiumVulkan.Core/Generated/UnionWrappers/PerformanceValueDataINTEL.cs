// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class PerformanceValueDataINTEL : QBDisposableObject
{
    private MarshaledString _valueString;

    public PerformanceValueDataINTEL()
    {
    }

    public PerformanceValueDataINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceValueDataINTEL _internal)
    {
        Value32 = _internal.value32;
        Value64 = _internal.value64;
        ValueFloat = _internal.valueFloat;
        ValueBool = _internal.valueBool;
        ValueString = new string(_internal.valueString);
    }

    public uint Value32 { get; set; }
    public ulong Value64 { get; set; }
    public float ValueFloat { get; set; }
    public VkBool32 ValueBool { get; set; }
    public string ValueString { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPerformanceValueDataINTEL ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPerformanceValueDataINTEL();
        if (Value32 != default)
        {
            _internal.value32 = Value32;
        }
        if (Value64 != default)
        {
            _internal.value64 = Value64;
        }
        if (ValueFloat != default)
        {
            _internal.valueFloat = ValueFloat;
        }
        if (ValueBool != (uint)default)
        {
            _internal.valueBool = ValueBool;
        }
        _valueString.Dispose();
        if (ValueString != default)
        {
            _valueString = new MarshaledString(ValueString, false);
            _internal.valueString = (sbyte*)_valueString;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _valueString.Dispose();
    }


    public static implicit operator PerformanceValueDataINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceValueDataINTEL p)
    {
        return new PerformanceValueDataINTEL(p);
    }

}



