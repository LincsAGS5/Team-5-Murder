Shader "Custom/shdCursor"
{
	Properties
	{
		_Color ("Main Colour", Color) = (1.0, 1.0, 1.0, 1.0)
		_Emission ("Emission", Color) = (0.0, 0.0, 0.0, 1.0)
	}
	SubShader
	{
		Tags { "RenderType"="Transparent" "Queue"="Transparent"}
		LOD 200
		
		Blend One One
		
		CGPROGRAM
		#pragma surface surf Lambert alpha vertex:vert

		half4 _Color;
		half4 _Emission;

		struct Input
		{
			half3 localPos;
		};
		
		void vert (inout appdata_full v, out Input o)
		{
			UNITY_INITIALIZE_OUTPUT(Input, o);
			o.localPos = v.vertex.xyz;
		}

		void surf (Input IN, inout SurfaceOutput o)
		{
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a * (1.0f - IN.localPos.y);
			o.Emission = _Emission.rgb;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
