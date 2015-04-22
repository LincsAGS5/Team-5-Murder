             using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private Vector3 direction;
	public float sensitivityX = 2F;
	public float sensitivityY = 8F;
	// Use this for initialization
	void Start () 
	{
	
	}

	void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate(0, Input.GetAxisRaw("Horizontal") * sensitivityX, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate(0, Input.GetAxisRaw("Horizontal") * sensitivityX, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			direction = new Vector3 (0, 0, Input.GetAxis ("Vertical") * sensitivityY);
			GetComponent<Rigidbody>().velocity = transform.rotation * direction;
		} 
		else 
		{
			if (Input.GetKey (KeyCode.DownArrow)) 
			{
				direction = new Vector3 (0, 0, Input.GetAxis ("Vertical") * sensitivityY);
				GetComponent<Rigidbody>().velocity = transform.rotation * direction;
			}
			else
			{
				GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			}
		}
	}


}
