// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Shaders.Interop;

namespace AdamantiumVulkan.Shaders;

public unsafe partial class ShadercIncludeResult : QBDisposableObject
{
    private MarshaledString _source_name;

    private MarshaledString _content;

    public ShadercIncludeResult()
    {
    }

    public ShadercIncludeResult(AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult _internal)
    {
        Source_name = new string(_internal.source_name);
        Source_name_length = _internal.source_name_length;
        Content = new string(_internal.content);
        Content_length = _internal.content_length;
        User_data = _internal.user_data;
    }

    public string Source_name { get; set; }
    public ulong Source_name_length { get; set; }
    public string Content { get; set; }
    public ulong Content_length { get; set; }
    public void* User_data { get; set; }

    public AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult ToNative()
    {
        var _internal = new AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult();
        _source_name.Dispose();
        if (Source_name != default)
        {
            _source_name = new MarshaledString(Source_name, false);
            _internal.source_name = (sbyte*)_source_name;
        }
        if (Source_name_length != default)
        {
            _internal.source_name_length = Source_name_length;
        }
        _content.Dispose();
        if (Content != default)
        {
            _content = new MarshaledString(Content, false);
            _internal.content = (sbyte*)_content;
        }
        if (Content_length != default)
        {
            _internal.content_length = Content_length;
        }
        _internal.user_data = User_data;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _source_name.Dispose();
        _content.Dispose();
    }


    public static implicit operator ShadercIncludeResult(AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult s)
    {
        return new ShadercIncludeResult(s);
    }

}



