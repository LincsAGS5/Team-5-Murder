using UnityEngine;
using System.Collections;

public class KeepOnLoad : MonoBehaviour {

	//static GameObject instance;
	public bool CrackedPlate;
	public bool Parchment;
	public bool Maid;
	public bool BloodSplatter;
	public bool Footprints;
	public bool Knife;
	public int CrackedPlatePosition = 0;
	
	// Use this for initialization
	void Start () { 
		
		
	}
	void Awake() {
		//instance = this;
		DontDestroyOnLoad(gameObject);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
