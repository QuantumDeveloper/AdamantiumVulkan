// Slang port of BasicShader.hlsl - same two cube shaders, compiled natively via the Slang runtime
// (AdamantiumVulkan.Slang) instead of DXC. One textured cube + one vertex-coloured cube, selected by the
// useTexture push-constant flag.

struct VSInput
{
    float3 position : POSITION0;
    float3 color : COLOR;
    float2 texcoord : TEXCOORD;
};

struct VSOutput
{
    float4 position : SV_Position;
    float3 color : COLOR;
    float2 texcoord : TEXCOORD;
};

struct PushConstants
{
    float4x4 mvp;
    int useTexture;
};

[[vk::push_constant]]
ConstantBuffer<PushConstants> pc;

[[vk::binding(0)]]
Sampler2D shaderTexture;

[shader("vertex")]
VSOutput VertexMain(VSInput input)
{
    VSOutput output;
    output.position = mul(pc.mvp, float4(input.position, 1.0));
    output.color = input.color;
    output.texcoord = input.texcoord;
    return output;
}

[shader("fragment")]
float4 FragmentMain(VSOutput input) : SV_Target
{
    if (pc.useTexture != 0)
    {
        return shaderTexture.Sample(input.texcoord);
    }
    return float4(input.color, 1.0);
}
