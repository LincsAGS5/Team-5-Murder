using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour
{

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {
       GUI.Label(new Rect ((Screen.width)/2 - 175, (Screen.height) /2 - 180, 500,500),"Game Complete, You Solved the Mystery!");

       if (GUI.Button(new Rect((Screen.width) / 4 * 1.6f, (Screen.height) / 8 * 4, 120, 50), "Play Again!"))
       {
           Application.LoadLevel(0);
       }

       if (GUI.Button(new Rect((Screen.width) / 4 * 2.2f, (Screen.height) / 8 * 4, 120, 50), "Exit Game!"))
       {
           Application.Quit();
       }

    }
}
