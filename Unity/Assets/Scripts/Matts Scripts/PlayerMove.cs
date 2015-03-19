using UnityEngine;
using System.Collections;

using KinectForWheelchair;

public class PlayerMove : MonoBehaviour
{

    public InputController inputController;

    public bool kinectEnabled = true;
    public bool controllerEnabled = true;
    public bool canMove = true;

    public float playerPos;
    bool runOnce = true;

    public bool canLock = true;
    public bool canRotate = true;
    RotateLock rl;

    // Use this for initialization
    void Start()
    {
        //Screen.lockCursor = true;
        rl = GameObject.Find("Dial").GetComponent<RotateLock>();
        return;
    }

    // Update is called once per frame
    void Update()
    {
        //if (controllerEnabled == true)
        //{
        //    if (Input.GetAxis("Joystick Triggers") > 0.05)
        //    {
        //        this.transform.Rotate(Vector3.down * (Input.GetAxis("Joystick Triggers") * 5));
        //    }
        //    else if (Input.GetAxis("Joystick Triggers") < -0.05)
        //    {
        //        this.transform.Rotate(Vector3.down * (Input.GetAxis("Joystick Triggers") * 5));
        //    }

        //    if (Input.GetAxis("Joystick Right") > 0.09)
        //    {
        //        this.transform.Translate(0, 0, -0.01f);
        //    }
        //    else if (Input.GetAxis("Joystick Right") < -0.09)
        //    {
        //        this.transform.Translate(0, 0, 0.01f);
        //    }
        //    //Debug.Log(Input.GetAxis("Joystick Triggers"));
        //}



        // Get the input info
        SeatedInfo inputInfo = this.inputController.InputInfo;
        if (inputInfo == null)
            return;

        // Set the player position and direction
        if (inputInfo.Features == null)
            return;

        if (runOnce == true)
        {
            playerPos = inputInfo.Features.Position.y;

            runOnce = false;
        }

        //Debug.Log (inputInfo.Features.Position);
        //this.transform.position = new Vector3(inputInfo.Features.Position.x, 0, inputInfo.Features.Position.y) * 5;
        //this.transform.forward = new Vector3(inputInfo.Features.Direction.x, 0, inputInfo.Features.Direction.y) * 5;

        if (kinectEnabled == true && canMove == true)
        {

            if (inputInfo.Features.Angle > 5)
            {
                //this.transform.rotation = new Quaternion(0, 0, this.transform.rotation.z + inputInfo.Features.Angle, 0.1f);
                //this.transform.Rotate(Vector3.back * (inputInfo.Features.Angle / 20));
                this.transform.Rotate(Vector3.up * Time.deltaTime * 8);
            }
            else if (inputInfo.Features.Angle < -5)
            {
                //this.transform.rotation = Quaternion(0, 0, this.transform.rotation.z + inputInfo.Features.Angle, 0.1f);
                //this.transform.Rotate(Vector3.back * (inputInfo.Features.Angle / 20));
                this.transform.Rotate(Vector3.down * Time.deltaTime * 8);
            }

            //Debug.Log(inputInfo.Features.Position.y);

            if (inputInfo.Features.Position.y > playerPos + 0.09)
            {
                this.transform.Translate(0, 0, -0.01f);
            }
            else if (inputInfo.Features.Position.y < playerPos - 0.09)
            {
                this.transform.Translate(0, 0, 0.01f);
            }

            if (inputInfo.Features.DistanceBetweenHands > 0.7)
            {
                this.GetComponent<ExamineObject>().interact();
            }
            //this.transform.rotation = new Quaternion(0, 0, inputInfo.Features.Angle,0);
            //Debug.Log(inputInfo.Features.Angle);

            //this.transform.forward = new Vector3(0, 0, inputInfo.Features.Direction.y) * 5;

            //if (Input.GetAxis("Joystick Right") > 0.05)
            //this.transform.forward = new Vector3(0, 0, inputInfo.Features.Direction.y) * 5;

        }

        if (kinectEnabled == true && canLock == true)
        {
            if (inputInfo.Features.Angle > 5)
            {
                //this.transform.rotation = new Quaternion(0, 0, this.transform.rotation.z + inputInfo.Features.Angle, 0.1f);
                //this.transform.Rotate(Vector3.back * (inputInfo.Features.Angle / 20));
                //if (canRotate)
                //{
                rl.RotateLeft();
                //Debug.Log("Rotating right");
                canRotate = false;
                // }
            }
            else if (inputInfo.Features.Angle < -5)
            {
                //this.transform.rotation = Quaternion(0, 0, this.transform.rotation.z + inputInfo.Features.Angle, 0.1f);
                //this.transform.Rotate(Vector3.back * (inputInfo.Features.Angle / 20));

                //if (canRotate)
                //{
                rl.RotateRight();
                canRotate = false;
                //}
            }
            else if (inputInfo.Features.Angle > -5 && inputInfo.Features.Angle < 5)
            {
                if (!canRotate)
                {
                    canRotate = true;
                }
            }
            //this.transform.rotation = new Quaternion(0, 0, inputInfo.Features.Angle,0);
            Debug.Log(inputInfo.Features.Angle);
        }



        return;
    }
}
