using UnityEngine;
using System.Collections;

public class scrBookRandomiser : MonoBehaviour
{
	static Color[] colours = new Color[] { Color.grey, Color.red, Color.yellow, Color.green, Color.cyan, Color.blue, Color.black };
	static Material[] randomMaterials;
	static bool initialised = false;

	// Use this for initialization
	void Start ()
	{
		// Initialise the materials array if this is the first instance of the script being run.
		if (!initialised)
		{
			randomMaterials = new Material[colours.Length * 2];
			for (int i = 0; i < randomMaterials.Length; ++i)
			{
				randomMaterials[i] = new Material(Shader.Find ("Diffuse"));
				randomMaterials[i].color = Color.Lerp (Color.Lerp (colours[i % colours.Length], colours[Random.Range (0, colours.Length)],
				                                       Random.Range (0.0f, 1.0f)), Color.grey, 0.4f);
			}
		}

		// Assign materials randomly to each book.
		foreach (Renderer r in GetComponentsInChildren<Renderer>())
		{
			r.material = randomMaterials[Random.Range (0, randomMaterials.Length)];
		}
	}
}
