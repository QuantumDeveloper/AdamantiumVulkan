struct VSInput
{
    [[vk::location(0)]] float3 position : POSITION0;
    [[vk::location(1)]] float3 color: COLOR;
    [[vk::location(2)]] float2 texcoord: TEXCOORD;
};

struct VSOutput
{
    float4 position : SV_POSITION;
    [[vk::location(1)]] float3 color: COLOR;
    [[vk::location(2)]] float2 texcoord: TEXCOORD;
};

struct PushConstants
{
    float4x4 mvp;
    int useTexture;
};
[[vk::push_constant]] PushConstants pc;

VSOutput VertexMain(VSInput input)
{
    VSOutput output;

    output.position = mul(pc.mvp, float4(input.position, 1.0));
    output.color = input.color;
    output.texcoord = input.texcoord;

    return output;
}

sampler sampleType: register(s0);
Texture2D shaderTexture: register(t0);

float4 FragmentMain(VSOutput input) : SV_TARGET
{
    if (pc.useTexture != 0)
    {
        return shaderTexture.Sample(sampleType, input.texcoord);
    }
    return float4(input.color, 1.0);
}
