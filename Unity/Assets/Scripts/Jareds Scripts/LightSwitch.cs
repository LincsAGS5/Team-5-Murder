using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {

   public Light bedLight;
    bool lightOn = false;

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
        bedLight.intensity = 100;
        bedLight.range = 100;


       
    }
}
