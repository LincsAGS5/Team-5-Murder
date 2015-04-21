using UnityEngine;
using System.Collections;

using KinectForWheelchair;

public class LockMovement : MonoBehaviour
{

    public InputController inputController;

    public bool kinectEnabled = true;
    public bool controllerEnabled = true;
    public bool canMove = true;
    

    // Use this for initialization
    void Start()
    {
        //rl = GameObject.Find("Dial").GetComponent<RotateLock>();
        return;
    }

    // Update is called once per frame
    void Update()
    {
        if (controllerEnabled == true)
        {
            //if (Input.GetAxis("Joystick Triggers") > 0.05)
            //{
            //    this.transform.Rotate(Vector3.forward * (Input.GetAxis("Joystick Triggers") * 5));
            //}
            //else if (Input.GetAxis("Joystick Triggers") < -0.05)
            //{
            //    this.transform.Rotate(Vector3.forward * (Input.GetAxis("Joystick Triggers") * 5));
            //}
            ////Debug.Log(Input.GetAxis("Joystick Triggers"));
        }

        // Get the input info
        SeatedInfo inputInfo = this.inputController.InputInfo;
        if (inputInfo == null)
            return;

        // Set the player position and direction
        if (inputInfo.Features == null)
            return;

        //Debug.Log (inputInfo.Features.Position);
        //this.transform.position = new Vector3(inputInfo.Features.Position.x, 0, inputInfo.Features.Position.y) * 5;
        //this.transform.forward = new Vector3(inputInfo.Features.Direction.x, 0, inputInfo.Features.Direction.y) * 5;

        if (kinectEnabled == true && canMove)
        {

            
        }



        return;
    }
}
