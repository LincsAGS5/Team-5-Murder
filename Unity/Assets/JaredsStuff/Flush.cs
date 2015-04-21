using UnityEngine;
using System.Collections;

public class Flush : MonoBehaviour 
{

   public bool flush = false;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (flush == true)
        {
            transform.Rotate(Vector3.back * Time.deltaTime * 5);

        }	
	}


    void OnMouseDown()
    {
        flush = true;
    }




    void Flusher()
    {
        if (flush == true)
        {


        }
    }
}
