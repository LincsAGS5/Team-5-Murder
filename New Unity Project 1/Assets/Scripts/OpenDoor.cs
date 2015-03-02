using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour 
{

  public  bool SlideOpenTheDoor = false;
    float WaitTime = 3;

	// Use this for initialization
	void Start ()
    {
	}
	


    void StopDoor()
    {

        SlideOpenTheDoor = false;
    }


    public void OpenTheDoor()
    {

        SlideOpenTheDoor = true;
        Invoke("StopDoor", 4); 
    }

	// Update is called once per frame
	void Update () 
    {

        if (SlideOpenTheDoor == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }

       // Invoke ("StopDoor", 4); 
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(175, 540, 140, 30), "Force the Door Open!"))
        {

            OpenTheDoor();
        }
    }



}

