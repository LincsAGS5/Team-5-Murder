using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {



    public Camera camera1;
    public static int Lockoff = 0;
    

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Lockoff == 0)
        {
            camera1.enabled = false;
        }

        if (Lockoff == 1)
        {
            camera1.enabled = true;
        }
	}
}
