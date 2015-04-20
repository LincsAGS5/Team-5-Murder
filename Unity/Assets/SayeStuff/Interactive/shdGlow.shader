Shader "Custom/shdGlow"
{
	Properties
	{
		_MainColor ("Main Colour", Color) = (1, 1, 1, 1)
		_GlowColor ("Glow Colour", Color) = (1, 1, 1, 1)
		_GlowDistance ("Glow Distance", Float) = 0.2
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_BumpMap ("Normal Map", 2D) = "bump" {}
		_Selected ("Selected", int) = 1
	}
	SubShader
	{
		Tags { "Queue"="Transparent-1" "RenderType"="Transparent" }
		
		Blend SrcAlpha One
		ZWrite Off
		
		CGPROGRAM
		#pragma surface surf Lambert vertex:vert

		half4 _GlowColor;
		half _GlowDistance;
		int _Selected;

		struct Input
		{
			float3 viewDir;
		};
		
		void vert (inout appdata_full v)
		{
			if (_Selected != 0)
			{
				// Expand the mesh for a surrounding glow.
				
				if (_Selected == 1)
					v.vertex.xyz += v.normal * _GlowDistance;	// Works better with round objects.
				else if (_Selected == 2)
					v.vertex.xyz *= 1 + _GlowDistance;	// Works better with sharp objects.
			}
		}

		void surf (Input IN, inout SurfaceOutput o)
		{
			if (_Selected != 0)
			{
				o.Emission = _GlowColor.rgb;
				
				// Reduce the glow amount by the difference from the viewing angle so that rounder objects have softer glows.
				o.Alpha = _GlowColor.a * pow(dot(normalize(IN.viewDir), o.Normal), 2.0);
			}
			else
			{		
				clip(-1);
			}
		}
		ENDCG
		
		Tags { "Queue"="Opaque" "RenderType"="Opaque" }
        Blend Off
        ZWrite On
        
		CGPROGRAM
		#pragma surface surf Lambert

		half4 _MainColor;
		half4 _GlowColor;
		sampler2D _MainTex;
		sampler2D _BumpMap;
		int _Selected;
		
		struct Input
		{
			float2 uv_MainTex;
			float2 uv_BumpMap;
			float3 viewDir;
		};

		void surf (Input IN, inout SurfaceOutput o)
		{
			half4 c = tex2D (_MainTex, IN.uv_MainTex) * _MainColor;
			o.Albedo = c.rgb;
			o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
			
			// If selected, create a glow from the edges of the object inwards, based on their normals.
			if (_Selected != 0)
				o.Emission = 2 * _GlowColor.rgb * pow(1.0 - dot(normalize(IN.viewDir), o.Normal), 2);
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
