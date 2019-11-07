//#include "..\NoiseGeneration\PerlinNoise.hlsl"
#include "..\NoiseGeneration\OpenSimplexNoise.hlsl"

const static int permutationTableSize = 1024;
const static int gradientSetSize = 26;

cbuffer PerlinParams : register(b0)
{
	//pseudorandom hash modifiers
	int mX;
	int mY;
	int mZ;

	//permutation table
	int permutationTable[1024];
	//gradients' set
	float3 gradientSet[26];
};

float3 GetGradient(int x, int y, int z, bool isLessGradients)
{
	//pick random cell in permutation table (cells 0 to 'permutationTableSize')
	int index = (int)((x * mX) ^ (y * mY) + z * mZ + (mX * mY * mZ)) & (permutationTableSize - 1);

	if (isLessGradients == false)
	{
		//pick random cell in gradientSet vector
		index = permutationTable[index] & (gradientSetSize - 1);

		//return the content of the picked cell
		return gradientSet[index];
	}
	else
	{
		//ALTERNATIVE IMPLEMENTATION FOR 12 GRADIENT VECTORS
		index = permutationTable[index] & 11;

		switch (index)
		{
		case 0:
			return float3(0, 1, 1);
		case 1:
			return float3(0, 1, -1);
		case 2:
			return float3(0, -1, 1);
		case 3:
			return float3(0, -1, -1);
		case 4:
			return float3(1, 0, 1);
		case 5:
			return float3(1, 0, -1);
		case 6:
			return float3(-1, 0, 1);
		case 7:
			return float3(-1, 0, -1);
		case 8:
			return float3(1, 1, 0);
		case 9:
			return float3(1, -1, 0);
		case 10:
			return float3(-1, 1, 0);
		default:
			return float3(-1, -1, 0);
		}
	}
}

float BlendingCurve(float d)
{
	return (d * d * d * (d * (d * 6.0 - 15.0) + 10.0));
}

float Interpolation(float a, float b, float t)
{
	return ((1.0 - t) * a + t * b);
}

float Get3DNoiseValue(float x, float y, float z)
{
	// find unit grid cell containing point
	int floorX = floor(x);
	int floorY = floor(y);
	int floorZ = floor(z);

	// get relative XYZ coordinates of point in cell
	float relX = x - floorX;
	float relY = y - floorY;
	float relZ = z - floorZ;

	//gradients of cube vertices
	float3 g000 = GetGradient(floorX, floorY, floorZ, false);
	float3 g001 = GetGradient(floorX, floorY, floorZ + 1, false);
	float3 g010 = GetGradient(floorX, floorY + 1, floorZ, false);
	float3 g011 = GetGradient(floorX, floorY + 1, floorZ + 1, false);
	float3 g100 = GetGradient(floorX + 1, floorY, floorZ, false);
	float3 g101 = GetGradient(floorX + 1, floorY, floorZ + 1, false);
	float3 g110 = GetGradient(floorX + 1, floorY + 1, floorZ, false);
	float3 g111 = GetGradient(floorX + 1, floorY + 1, floorZ + 1, false);

	// noise contribution from each of the eight corners
	float n000 = dot(g000, float3(relX, relY, relZ));
	float n100 = dot(g100, float3(relX - 1, relY, relZ));
	float n010 = dot(g010, float3(relX, relY - 1, relZ));
	float n110 = dot(g110, float3(relX - 1, relY - 1, relZ));
	float n001 = dot(g001, float3(relX, relY, relZ - 1));
	float n101 = dot(g101, float3(relX - 1, relY, relZ - 1));
	float n011 = dot(g011, float3(relX, relY - 1, relZ - 1));
	float n111 = dot(g111, float3(relX - 1, relY - 1, relZ - 1));

	// compute the fade curve value for each x, y, z
	float u = BlendingCurve(relX);
	float v = BlendingCurve(relY);
	float w = BlendingCurve(relZ);

	// interpolate along x the contribution from each of the corners
	float nx00 = lerp(n000, n100, u);
	float nx01 = lerp(n001, n101, u);
	float nx10 = lerp(n010, n110, u);
	float nx11 = lerp(n011, n111, u);

	// interpolate the four results along y
	float nxy0 = lerp(nx00, nx10, v);
	float nxy1 = lerp(nx01, nx11, v);

	// interpolate the two last results along z
	float nxyz = lerp(nxy0, nxy1, w);

	return nxyz;
}

float GetNoiseValue(float3 p)
{
	return Get3DNoiseValue(p.x, p.y, p.z);
}

float GetMultioctave3DNoiseValue(float3 p, float4 modifiers, uint startOctaveNumber, uint octaveCount)
{
	float res = 0;

	for (uint i = startOctaveNumber; i < (startOctaveNumber + octaveCount); ++i)
	{
		float powOf2 = pow(2, i);
		//res += (powOf2 * Get3DNoiseValue(x / powOf2, y / powOf2, z / powOf2));
		res += modifiers.w * (Get3DNoiseValue(p.x / (powOf2 * modifiers.x), p.y / (powOf2 * modifiers.y), p.z / (powOf2 * modifiers.z)));
	}

	return res;
}

float GetMultioctave3DNoiseValueFromSphere(float3 p, float4 modifiers, uint startOctaveNumber, uint octaveCount, uint radius)
{
	//convert to sphere coordinates
	float d = pow(p.x, 2) + pow(p.y, 2) + pow(p.z, 2);
	d = sqrt(d);

	float zd = p.z / d;

	float theta = acos(zd);
	float phi = atan2(p.y, p.x);

	float sx = radius * sin(theta) * cos(phi);
	float sy = radius * sin(theta) * sin(phi);
	float sz = radius * cos(theta);

	float3 spherePoint = float3(sx, sy, sz);

	return GetMultioctave3DNoiseValue(spherePoint, modifiers, startOctaveNumber, octaveCount);
}


cbuffer MC : register(b1)
{
    float isolevel = 0.5;
    float3 decal[8];
    int EdgeTable[256];
}

cbuffer Pos : register(b2)
{
    float3 origin;
}

//Triangle look up table
Texture2D<int> tritableTex;

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

/* Interpolates between the given points by a specific amount
Used to find the vertex position on the cube's edge*/
float3 vertexInterp(float isoLevel, float3 v0, float l0, float3 v1, float l1)
{
    float lerper = (isoLevel - l0) / (l1 - l0);
    return lerp(v0, v1, lerper);
}

/*
Gets a value from the look-up table
*/
int triTableValue(int i, int j)
{
    if (i >= 256 || j >= 16)
    {
        return -1;
    }

    return tritableTex.Load(int3(j, i, 0));
}

void CalculateGridCell(float3 cubePoses[8], float cubeVals[8], inout TriangleStream<GS_OUTPUT> triStream)
{
    int cubeIndex = 0;
    if (cubeVals[0] < isolevel)
        cubeIndex |= 1;
    if (cubeVals[1] < isolevel)
        cubeIndex |= 2;
    if (cubeVals[2] < isolevel)
        cubeIndex |= 4;
    if (cubeVals[3] < isolevel)
        cubeIndex |= 8;
    if (cubeVals[4] < isolevel)
        cubeIndex |= 16;
    if (cubeVals[5] < isolevel)
        cubeIndex |= 32;
    if (cubeVals[6] < isolevel)
        cubeIndex |= 64;
    if (cubeVals[7] < isolevel)
        cubeIndex |= 128;

    GS_OUTPUT output = (GS_OUTPUT) 0;
    
	/* Cube is entirely in/out of the surface */
    if (EdgeTable[cubeIndex] != 0)
    {
      float3 vertlist[12] =
      {
         float3(0, 0, 0), float3(0, 0, 0), float3(0, 0, 0), float3(0, 0, 0),
         float3(0, 0, 0), float3(0, 0, 0), float3(0, 0, 0), float3(0, 0, 0),
         float3(0, 0, 0), float3(0, 0, 0), float3(0, 0, 0), float3(0, 0, 0)
      };

		   //Find the vertices where the surface intersects the cube
        if ((EdgeTable[cubeIndex] & 1) != 0)
        {
            vertlist[0] = vertexInterp(isolevel, cubePoses[0], cubeVals[0], cubePoses[1], cubeVals[1]);
        }
        if ((EdgeTable[cubeIndex] & 2) != 0)
        {
            vertlist[1] = vertexInterp(isolevel, cubePoses[1], cubeVals[1], cubePoses[2], cubeVals[2]);
        }
        if ((EdgeTable[cubeIndex] & 4) != 0)
        {
            vertlist[2] = vertexInterp(isolevel, cubePoses[2], cubeVals[2], cubePoses[3], cubeVals[3]);
        }
        if ((EdgeTable[cubeIndex] & 8) != 0)
        {
            vertlist[3] = vertexInterp(isolevel, cubePoses[3], cubeVals[3], cubePoses[0], cubeVals[0]);
        }
        if ((EdgeTable[cubeIndex] & 16) != 0)
        {
            vertlist[4] = vertexInterp(isolevel, cubePoses[4], cubeVals[4], cubePoses[5], cubeVals[5]);
        }
        if ((EdgeTable[cubeIndex] & 32) != 0)
        {
            vertlist[5] = vertexInterp(isolevel, cubePoses[5], cubeVals[5], cubePoses[6], cubeVals[6]);
        }
        if ((EdgeTable[cubeIndex] & 64) != 0)
        {
            vertlist[6] = vertexInterp(isolevel, cubePoses[6], cubeVals[6], cubePoses[7], cubeVals[7]);
        }
        if ((EdgeTable[cubeIndex] & 128) != 0)
        {
            vertlist[7] = vertexInterp(isolevel, cubePoses[7], cubeVals[7], cubePoses[4], cubeVals[4]);
        }
        if ((EdgeTable[cubeIndex] & 256) != 0)
        {
            vertlist[8] = vertexInterp(isolevel, cubePoses[0], cubeVals[0], cubePoses[4], cubeVals[4]);
        }
        if ((EdgeTable[cubeIndex] & 512) != 0)
        {
            vertlist[9] = vertexInterp(isolevel, cubePoses[1], cubeVals[1], cubePoses[5], cubeVals[5]);
        }
        if ((EdgeTable[cubeIndex] & 1024) != 0)
        {
            vertlist[10] = vertexInterp(isolevel, cubePoses[2], cubeVals[2], cubePoses[6], cubeVals[6]);
        }
        if ((EdgeTable[cubeIndex] & 2048) != 0)
        {
            vertlist[11] = vertexInterp(isolevel, cubePoses[3], cubeVals[3], cubePoses[7], cubeVals[7]);
        }

        GS_OUTPUT point1 = (GS_OUTPUT)0;
        GS_OUTPUT point2 = (GS_OUTPUT) 0;
        GS_OUTPUT point3 = (GS_OUTPUT) 0;
        
        [loop]
        for (int i = 0; triTableValue(cubeIndex, i) != -1; i += 3)
        {
			//Add vertices to the output stream
            output.Pos = float4(vertlist[triTableValue(cubeIndex, i + 0)], 1);
            point1 = output;
			
            output.Pos = float4(vertlist[triTableValue(cubeIndex, i + 1)], 1);
            point2 = output;
				
            output.Pos = float4(vertlist[triTableValue(cubeIndex, i + 2)], 1);
            point3 = output;

            float3 P0 = point1.Pos.xyz;
            float3 P1 = point2.Pos.xyz;
            float3 P2 = point3.Pos.xyz;

            float3 V0 = P0 - P1;
            float3 V1 = P2 - P1;

            float3 N = cross(V1, V0);
            N = normalize(N);

            point1.Normal = N;
            point2.Normal = N;
            point3.Normal = N;

            point1.UV = float2(0, 0);
            point2.UV = float2(0.5, 0);
            point3.UV = float2(1, 1);

            triStream.Append(point1);
            triStream.Append(point2);
            triStream.Append(point3);
            triStream.RestartStrip();
        }
    }
}

GS_INPUT MarchingCubes_VS(float4 input : SV_POSITION)
{
    GS_INPUT output;
    output.Pos = float4(input.xyz + origin, 1);
    return output;
}

[maxvertexcount(15)]
void MarchingCubes_GS(point GS_INPUT input[1], inout TriangleStream<GS_OUTPUT> triStream)
{
    float3 position = input[0].Pos.xyz;

    float3 cubePoses[8];
    float cubeVals[8];
    for (int i = 0; i < 8; i++)
    {
        cubePoses[i] = position + decal[i];
        cubeVals[i] = -cubePoses[i].y;
        float noise = GetNoiseValue(cubePoses[i]);
        cubeVals[i] += (noise * 4.03f) * 0.25f;
        cubeVals[i] += (noise * 1.96f) * 0.50f;
        cubeVals[i] += (noise * 1.01f) * 1.00f;
      
		//cubeVals[i] += (noise * 4.03f) * 0.25f;
		//cubeVals[i] += (noise * 1.96f) * 0.50f;
		//cubeVals[i] += (noise * 1.01f) * 1.00f;
    }

    CalculateGridCell(cubePoses, cubeVals, triStream);
}

[maxvertexcount(15)]
void OSMarchingCubes_GS(point GS_INPUT input[1], inout TriangleStream<GS_OUTPUT> triStream)
{
    float3 position = input[0].Pos.xyz;
    float3 cubePoses[8];
    float cubeVals[8];
    for (int i = 0; i < 8; i++)
    {
        cubePoses[i] = position.xyz + decal[i].xyz;
        cubeVals[i] = -cubePoses[i].y;
        float noise = GetNoiseValue(cubePoses[i]);
        // float noise = 0.5;
        cubeVals[i] += (noise * 4.03f) * 0.25f;
        cubeVals[i] += (noise * 1.96f) * 0.50f;
        cubeVals[i] += (noise * 1.01f) * 1.00f;
		//cubeVals[i] += (noise * 4.03f) * 0.25f;
		//cubeVals[i] += (noise * 1.96f) * 0.50f;
		//cubeVals[i] += (noise * 1.01f) * 1.00f;
    }

    CalculateGridCell(cubePoses, cubeVals, triStream);
}

//technique PerlinNoise
//{
//    pass TerrainGeneration
//    {
//        Profile = 10;
//        VertexShader = MarchingCubes_VS;
//        GeometryShader = MarchingCubes_GS;
//        StreamOutput = "SV_POSITION.xyz; NORMAL.xyz; TEXCOORD0.xy";
//        StreamOutputRasterizedStream = 0;
//        PixelShader = null;
//    }
//}

//technique OpenSimplexNoise
//{
//    pass MarchingCubesGeneration
//    {
//        Profile = 10;
//        VertexShader = MarchingCubes_VS;
//        GeometryShader = OSMarchingCubes_GS;
//        StreamOutput = "SV_POSITION.xyz; NORMAL.xyz; TEXCOORD0.xy";
//        StreamOutputRasterizedStream = 0;
//        PixelShader = null;
//    }
//}