using UnityEngine;
using System.Collections;

public class waterOff : MonoBehaviour {

	 
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void OnTriggerEnter()
	{
		gameObject.particleSystem.enableEmission = false;

	}
}
