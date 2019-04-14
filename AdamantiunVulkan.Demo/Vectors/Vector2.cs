using System.Runtime.InteropServices;

namespace VulkanEngineTestCore.Vectors
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Vector2
    {
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X;
        public float Y;
    }
}
