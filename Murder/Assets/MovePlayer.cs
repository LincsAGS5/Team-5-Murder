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
	
	// Update is called once per frame
	void Update () 
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
			rigidbody.velocity = transform.rotation * direction;
		} 
		else 
		{
			if (Input.GetKey (KeyCode.DownArrow)) 
			{
				direction = new Vector3 (0, 0, Input.GetAxis ("Vertical") * sensitivityY);
				rigidbody.velocity = transform.rotation * direction;
			}
			else
			{
				rigidbody.velocity = new Vector3(0,0,0);
			}
		}
	}

}
