using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Adamantium.Mathematics;


namespace VulkanEngineTestCore
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vertex
    {
        public Vector2F Position;
        public Vector3F Color;
        public Vector2F TexCoord;
    }
}
