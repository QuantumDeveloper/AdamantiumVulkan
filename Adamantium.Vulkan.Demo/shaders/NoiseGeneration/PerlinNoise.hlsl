const static int permutationTableSize = 1024;
const static int gradientSetSize = 26;

cbuffer PerlinParams : register(b0)
{
   //pseudorandom hash modifiers
   int mX;
   int mY;
   int mZ;

    //permutation table
   int permutationTable[permutationTableSize];
   //gradients' set
   float3 gradientSet[gradientSetSize];
};

float3 GetGradient(int x, int y, int z, bool isLessGradients)
{
   //pick random cell in permutation table (cells 0 to 'permutationTableSize')
   int index = (int) ((x * mX) ^ (y * mY) + z * mZ + (mX * mY * mZ)) & (permutationTableSize - 1);

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