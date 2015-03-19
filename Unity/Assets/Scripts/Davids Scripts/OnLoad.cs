using UnityEngine;
using System.Collections;

public class OnLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (LoadMain());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator LoadMain()
	{
		yield return new WaitForSeconds(5);
		Application.LoadLevel (1);
	}
}
