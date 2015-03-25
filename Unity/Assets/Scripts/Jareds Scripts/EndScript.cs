using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour
{
	public Font Mystery;
	public AudioSource mySound;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
		mySound.enabled = true;
		mySound.loop = true;
	}

    void OnGUI()
    {
		GUI.skin.font = Mystery;
		//GUI.contentColor = Color.red
       GUI.Label(new Rect ((Screen.width)/2 - 115, (Screen.height) /2 + 50, 500,500),"Game Complete, You Solved the Mystery!");
		GUI.Label(new Rect ((Screen.width)/2 - 25, (Screen.height) /2 + 100, 500,500),"Play Again?");


		     if (GUI.Button(new Rect((Screen.width)/2 - 75, (Screen.height) /2 + 150, 50,35), "Yes"))
     		{
         		 Application.LoadLevel(0);
     		}

			if (GUI.Button(new Rect((Screen.width)/2 + 50, (Screen.height) /2 + 150, 50,35), "No"))
			{
					Application.Quit();
			}

      

    }
}
