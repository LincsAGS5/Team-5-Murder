using UnityEngine;
using System.Collections;

public class InventoryDisplay : MonoBehaviour {


	public KeepOnLoad LoadObject;
	//public GameObject Description;
	public GameObject CrackedPlateButton;
	public GameObject FootprintsButton;
	public GameObject MaidButton;
	public GameObject ParchmentButton;
	public GameObject BloodSplatterButton;
	public GameObject KnifeButton;
	// Use this for initialization
	int count;
	int step;
	void Start ()
	{
		step = -40;
		count = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		var gos = GameObject.FindGameObjectsWithTag("KeepOnLoad");
		foreach (GameObject go in gos) 
		{
			if (go.GetComponent<KeepOnLoad> ().CrackedPlate == true) 
			{
				CrackedPlateButton.SetActive (true);
				CrackedPlateButton.transform.position = new Vector2 (CrackedPlateButton.transform.position.x, CrackedPlateButton.transform.position.y /*+ (go.GetComponent<KeepOnLoad> ().CrackedPlatePosition * step)*/);
			}
			if (go.GetComponent<KeepOnLoad> ().Footprints == true) 
			{
				FootprintsButton.SetActive (true);
				FootprintsButton.transform.position = new Vector2 (FootprintsButton.transform.position.x, FootprintsButton.transform.position.y /*+ (go.GetComponent<KeepOnLoad> ().CrackedPlatePosition * step)*/);
			}
			if (go.GetComponent<KeepOnLoad> ().Maid == true) 
			{
				MaidButton.SetActive (true);
				MaidButton.transform.position = new Vector2 (MaidButton.transform.position.x, MaidButton.transform.position.y /*+ (go.GetComponent<KeepOnLoad> ().CrackedPlatePosition * step)*/);
			}
			if (go.GetComponent<KeepOnLoad> ().Parchment == true) 
			{
				ParchmentButton.SetActive (true);
				ParchmentButton.transform.position = new Vector2 (ParchmentButton.transform.position.x, ParchmentButton.transform.position.y /*+ (go.GetComponent<KeepOnLoad> ().CrackedPlatePosition * step)*/);
			}
			if (go.GetComponent<KeepOnLoad> ().BloodSplatter == true) 
			{
				BloodSplatterButton.SetActive (true);
				BloodSplatterButton.transform.position = new Vector2 (BloodSplatterButton.transform.position.x, BloodSplatterButton.transform.position.y /*+ (go.GetComponent<KeepOnLoad> ().CrackedPlatePosition * step)*/);
			}
			if (go.GetComponent<KeepOnLoad> ().Knife == true) 
			{
				KnifeButton.SetActive (true);
				KnifeButton.transform.position = new Vector2 (KnifeButton.transform.position.x, KnifeButton.transform.position.y /*+ (go.GetComponent<KeepOnLoad> ().CrackedPlatePosition * step)*/);
			}
		}
	}

}