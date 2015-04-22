using UnityEngine;
using System.Collections;

public class TrackManager : MonoBehaviour 
{
    int lastPlayed = -1;

    GameObject audio1, audio2;


	// Use this for initialization
	void Start () 
    {


        audio1 = GameObject.Find("Background Music (On the Ground)");
        audio2 = GameObject.Find("Background Music (Martys Gots a Plan)");

        int i = Random.Range(0, 3);

        lastPlayed = i;

        switch (i)
        {
            case 1:
                audio1.GetComponent<AudioSource>().Play();
                break;
            case 2:
                audio2.GetComponent<AudioSource>().Play();
                break;
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
	}
}
