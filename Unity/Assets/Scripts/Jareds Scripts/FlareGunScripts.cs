﻿using UnityEngine;
using System.Collections;

public class FlareGunScripts : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnMouseDown()
    {
        Application.LoadLevel(1);
		Debug.Log ("Gun Clicked");
    }


}
