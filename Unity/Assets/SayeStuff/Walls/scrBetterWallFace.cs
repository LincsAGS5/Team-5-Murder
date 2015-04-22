using UnityEngine;
using System.Collections;

// Helper component that automatically fixes texture scaling on the faces of my BetterWall objects.
public class scrBetterWallFace : MonoBehaviour
{
	private static string[] textureNames = new string[] { "_MainTex", "_BumpMap" };

	public Vector2 FixedScale = Vector2.one;

	void Awake ()
	{
		// Change the material scale to account for the scale of the face it is assigned to.
		foreach (string texture in textureNames)
		{
			// Check whether the material has the texture property.
			if (GetComponent<Renderer>().material.HasProperty(texture))
			{
				// Modify the texture's scales.
				Vector2 scale = GetComponent<Renderer>().material.GetTextureScale(texture);
				scale.x = transform.lossyScale.x * scale.x / FixedScale.x;
				scale.y =  transform.lossyScale.y * scale.y / FixedScale.y;
				GetComponent<Renderer>().material.SetTextureScale(texture, scale);
			}
		}

		// Destroy this component, it has no further function.
		Destroy (this);
	}
}
