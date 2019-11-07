//Geometry shader input description
struct GS_INPUT
{
	float4 Pos : SV_POSITION;
};

struct GS_OUTPUT
{
	float4 Pos : SV_POSITION;
};

float3 origin;
//matrix WVP;

GS_INPUT MarchingCubes_VS(float4 input : SV_POSITION)
{
	GS_INPUT output;
	output.Pos = float4(input.xyz + origin, 1);
	//output.Pos = input.Pos;
   //output.Pos = mul(float4(input.Pos.xyz,1), WVP);
	return output;
}

[maxvertexcount(3)]
void MarchingCubes_GS(point GS_INPUT input[1], inout TriangleStream<GS_OUTPUT> triStream)
{
	//float3 position = input[0].Pos.xyz;
	GS_OUTPUT output;
	output.Pos = input[0].Pos;
	triStream.Append(output);
   triStream.Append(output);
   triStream.Append(output);
	triStream.RestartStrip();
}

float4 PS(GS_OUTPUT input) : SV_Target
{
   return float4(1,1,0,1);
}

technique PerlinNoise
{
	pass TerrainGeneration
	{
		Profile = 10;
		VertexShader = MarchingCubes_VS;
		GeometryShader = MarchingCubes_GS;
		StreamOutput = "SV_POSITION.xyz";
		StreamOutputRasterizedStream = 0;
      PixelShader = null;
   }
}