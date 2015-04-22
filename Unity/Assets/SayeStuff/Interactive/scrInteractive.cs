using UnityEngine;
using System.Collections;

public class scrInteractive : MonoBehaviour
{
	public GameObject Player;
	public bool Sharp;

	public void SetHighlight(bool value)
	{
		if (GetComponent<Renderer>() != null)
			GetComponent<Renderer>().material.SetInt("_Selected", value ? (Sharp ? 2 : 1) : 0);

		foreach (Renderer r in GetComponentsInChildren<Renderer>())
		{
			if (r.material.HasProperty("_Selected"))
				r.material.SetInt("_Selected", value ? (Sharp ? 2 : 1) : 0);
		}
	}
}
