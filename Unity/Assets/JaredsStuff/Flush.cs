using UnityEngine;
using System.Collections;

public class Flush : MonoBehaviour 
{

   public bool flush = false;
   public AudioClip toiletflushsound;
   public AudioSource[] sounds;
   public AudioSource noise1;
   bool soundOn = false;
   public GameObject water;


	// Use this for initialization
	void Start ()
    {

	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (flush == true)
        {
           
            transform.Rotate(Vector3.back * Time.deltaTime * 15);
            transform.Translate(Vector3.left * Time.deltaTime * 0.3f);
            transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
            transform.Translate(Vector3.down * Time.deltaTime * 0.08f);
            water.transform.Translate(Vector3.down * Time.deltaTime * 1.1f);
          
            Invoke("StopFlusher", 1.445f);
           

        }

        if (soundOn == true)
        {
            noise1.Play();
            this.gameObject.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().clip = toiletflushsound;
            this.GetComponent<AudioSource>().Play();
           

        }
	}


    void OnMouseDown()
    {
        flush = true;
    }




    void StopFlusher()
    {
        flush = false;
       
    }
}
