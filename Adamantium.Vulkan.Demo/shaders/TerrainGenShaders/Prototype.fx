cbuffer Pos : register(b2)
{
    float3 origin;
}

cbuffer Matr : register(b1)
{
   matrix wvp;
}

//Geometry shader input description
struct GS_INPUT
{
    float4 Pos : SV_POSITION;
};

struct GS_OUTPUT
{
    float4 Pos : SV_POSITION;
    float3 Normal : NORMAL;
    float2 UV : TEXCOORD0;
};

struct PS_INPUT
{
   float4 Pos : SV_POSITION;
   float3 Normal : NORMAL;
   //float2 UV : TEXCOORD0;
};

GS_INPUT MarchingCubes_VS(float4 input : SV_POSITION)
{
    GS_INPUT output;
    output.Pos = float4(input.xyz + origin, 1);
    return output;
}

[maxvertexcount(6)]
void MarchingCubes_GS(point GS_INPUT input[1], inout TriangleStream<GS_OUTPUT> triStream)
{
    float3 position = input[0].Pos.xyz;
    
    GS_OUTPUT point0;
    GS_OUTPUT point1;
    GS_OUTPUT point2;
    GS_OUTPUT point3;

   float3 N = float3(0, 1, 0);

    point0.Pos = float4(position, 1);
    point0.Normal = N;
    point0.UV = float2(0, 1);

    point1.Pos = float4(position + float3(0, 0, 1), 1);
    point1.Normal = N;
    point1.UV = float2(0, 0);

    point2.Pos = float4(position + float3(1, 0, 1), 1);
    point2.Normal = N;
    point2.UV = float2(1, 0);

    point3.Pos = float4(position + float3(1, 0, 0), 1);
    point3.Normal = N;
    point3.UV = float2(1, 1);

    point0.Pos = mul(point0.Pos, wvp);
    point1.Pos = mul(point1.Pos, wvp);
    point2.Pos = mul(point2.Pos, wvp);
    point3.Pos = mul(point3.Pos, wvp);
   
    triStream.Append(point0);
    triStream.Append(point1);
    triStream.Append(point2);
    triStream.RestartStrip();

    triStream.Append(point0);
    triStream.Append(point2);
    triStream.Append(point3);
    triStream.RestartStrip();

}

//PS_INPUT MarchingCubes_VS2(GS_OUTPUT input)
//{
//   PS_INPUT output;
//   output.Pos = mul(input.Pos, wvp);
   
//   return output;
//}

float4 PlanePS(GS_OUTPUT input) : SV_TARGET
{
   return float4(1,0,0,1);
}


technique ProtoTech
{
    pass TerrainGeneration
    {
        Profile = 10;
        VertexShader = MarchingCubes_VS;
        GeometryShader = MarchingCubes_GS;
        StreamOutput = "SV_POSITION.xyz; NORMAL.xyz; TEXCOORD0.xy";
        StreamOutputRasterizedStream = 0;
        PixelShader = PlanePS;
   }

   //pass Render
   //{
   //   Profile = 10;
   //   VertexShader = MarchingCubes_VS2;
   //   PixelShader = PlanePS;
   //}
}