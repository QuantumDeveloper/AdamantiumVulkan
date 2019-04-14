// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------


namespace AdamantiumVulkan.Shaders
{
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.Shaders;
    using AdamantiumVulkan.Shaders.Interop;

    public partial class ShadercIncludeResult : DisposableObject
    {
        private AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult _internal;

        private StringReference refsource_name;

        private StringReference refcontent;

        private GCHandleReference refuser_data;

        public ShadercIncludeResult()
        {
        }

        public ShadercIncludeResult(AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult _internal)
        {
            this._internal = _internal;
        }

        private string source_name;
        public string Source_name
        {
            get
            {
                if(source_name != null)
                    return source_name;

                source_name = Marshal.PtrToStringAnsi(_internal.source_name);
                return source_name;
            }
            set
            {
                refsource_name?.Dispose();
                refsource_name = new StringReference(value, false);
                source_name = value;
                _internal.source_name = refsource_name.Handle;
            }
        }

        public ulong Source_name_length
        {
            get => _internal.source_name_length;
            set
            {
                _internal.source_name_length = value;
            }
        }

        private string content;
        public string Content
        {
            get
            {
                if(content != null)
                    return content;

                content = Marshal.PtrToStringAnsi(_internal.content);
                return content;
            }
            set
            {
                refcontent?.Dispose();
                refcontent = new StringReference(value, false);
                content = value;
                _internal.content = refcontent.Handle;
            }
        }

        public ulong Content_length
        {
            get => _internal.content_length;
            set
            {
                _internal.content_length = value;
            }
        }

        private System.IntPtr user_data;
        public System.IntPtr User_data
        {
            get
            {
                if(user_data != null)
                    return user_data;

                user_data = _internal.user_data;
                return user_data;
            }
            set
            {
                refuser_data?.Dispose();
                refuser_data = new GCHandleReference(value);
                user_data = value;
                _internal.user_data = refuser_data.Handle;
            }
        }

        protected override void UnmanagedDisposeOverride()
        {
            refsource_name?.Dispose();
            refcontent?.Dispose();
            refuser_data?.Dispose();
        }

        public static implicit operator AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult(ShadercIncludeResult s)
        {
            return s._internal;
        }

        public static implicit operator ShadercIncludeResult(AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult s)
        {
            return new ShadercIncludeResult(s);
        }

    }


}
