int permutationTable2[10];
matrix wvp;

float4 fillColor;
sampler sampleType: register(s2);
Texture2D shaderTexture: register(t4);
sampler sampleType2: register(s5);
Texture2D shaderTexture2: register(t5);

float zNear;
float zFar;
float transparency = 1;
float transparency2 = 1;
double isThisOneByte;


const int permutationTableSize = 1024;
const int gradientSetSize = 26;


cbuffer PerlinParams
{
	//pseudorandom hash modifiers
	int mX;
	int mY;
	int mZ;
	//Texture2D someTexture;
	//permutation table
	int permutationTable[permutationTableSize];
	//gradients' set
	float3 gradientSet[gradientSetSize];
};

struct VertexInputType
{
   float4 position : SV_POSITION;
   float4 color: COLOR;
};

struct PixelInputType
{
   float4 position : SV_POSITION;
   float4 color: COLOR;
};

struct TexturedVertexInputType
{
   float4 position : SV_POSITION;
   float2 texcoord: TEXCOORD;
};

struct TexturedPixelInputType
{
   float4 position : SV_POSITION;
   float2 texcoord: TEXCOORD;
};


////////////////////////////////////////////////////////////////////////////////
// Vertex Shader
////////////////////////////////////////////////////////////////////////////////
PixelInputType LightVertexShader(VertexInputType input)
{
   PixelInputType output;
   output.color = float4(0, 0, 0, 0);
   output.position = float4(0, 0, 0, 0);


   // Change the position vector to be 4 units for proper matrix calculations.
   input.position.w = 1.0f;

   // Calculate the position of the vertex against the world, view, and projection matrices.

   output.position = mul(input.position, wvp);
   
   output.color = input.color;

   return output;
}

TexturedPixelInputType TexturedVertexShader(TexturedVertexInputType input)
{
   TexturedPixelInputType output;
   output.position = float4(0, 0, 0, 0);


   // Change the position vector to be 4 units for proper matrix calculations.
   input.position.w = 1.0f;

   // Calculate the position of the vertex against the world, view, and projection matrices.

   output.position = mul(input.position, wvp);
   
   output.texcoord = input.texcoord;
   return output;
}

float4 LightPixelShader(PixelInputType input) : SV_TARGET
{
   input.color.a = transparency;
   return input.color;
}

float4 SolidColorPixelShader(TexturedPixelInputType input) : SV_TARGET
{
   float4 result = fillColor;
   result.a *= transparency;
   return result;
}

float4 TexturedPixelShader(TexturedPixelInputType input) : SV_TARGET
{
   float4 result = fillColor;
   result.a *= transparency;
   float4 color = shaderTexture.Sample(sampleType, input.texcoord)* result;
   color = shaderTexture2.Sample(sampleType2, input.texcoord) * color;
   return color;
}


//technique10 Render
//{
//   pass Debug
//   {
//      SetVertexShader(CompileShader(vs_4_0, LightVertexShader()));
//      SetPixelShader(CompileShader(ps_4_0, LightPixelShader()));
//   }
//
//   pass SolidColor
//   {
//      SetVertexShader(CompileShader(vs_4_0, TexturedVertexShader()));
//      SetPixelShader(CompileShader(ps_4_0, SolidColorPixelShader()));
//   }
//
//   pass Textured
//   {
//      SetVertexShader(CompileShader(vs_4_0, TexturedVertexShader()));
//      SetPixelShader(CompileShader(ps_4_0, TexturedPixelShader()));
//   }
//}
