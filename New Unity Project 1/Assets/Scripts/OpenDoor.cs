using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour 
{

    bool slide = false;
    float WaitTime = 3;

	// Use this for initialization
	void Start ()
    {
	}
	


    void StopDoor()
    {

        slide = false;
    }

	// Update is called once per frame
	void Update () 
    {

        if (slide == true)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

       // Invoke ("StopDoor", 4); 
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 70, 80, 30), "Open Door"))
        {
            slide = true;
            Invoke("StopDoor", 4); 

        }
    }



}

