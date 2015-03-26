using UnityEngine;
using System.Collections;

public class scrInteractive : MonoBehaviour
{
	public GameObject Player;
	public float Distance;
	public bool Sharp;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		renderer.material.SetInt("_Selected", (Vector3.Distance(transform.position, Player.transform.position) < Distance) ? (Sharp ? 2 : 1) : 0);
	}
}
