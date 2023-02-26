struct VSInput
{
    [[vk::location(0)]] float2 position : POSITION0;
    [[vk::location(1)]] float3 color: COLOR;
    [[vk::location(2)]] float2 texcoord: TEXCOORD;
};

struct VSOutput
{
    float4 position : SV_POSITION;
    [[vk::location(1)]] float3 color: COLOR;
    [[vk::location(2)]] float2 texcoord: TEXCOORD;
};

VSOutput VertexMain(VSInput input)
{
    VSOutput output;

    output.position = float4(input.position, 0, 1);
    output.color = input.color;
    output.texcoord = input.texcoord;

    return output;
}

sampler sampleType: register(s0);
Texture2D shaderTexture: register(t0);

float4 FragmentMain(VSOutput input) : SV_TARGET
{
    float4 color = shaderTexture.Sample(sampleType, input.texcoord);
    return color;
}