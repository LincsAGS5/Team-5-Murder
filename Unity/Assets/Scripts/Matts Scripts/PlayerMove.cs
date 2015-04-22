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
    public bool cameraMove = false;

    bool waitForMove = false;

    GameObject dial;

    public Transform Target;

    // Use this for initialization
    void Start()
    {
        //Screen.lockCursor = true;
        rl = GameObject.Find("Dial").GetComponent<RotateLock>();
        dial = GameObject.Find("Dial");
        return;
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraMove == true)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, Target.transform.position, 0.1f);
            Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Target.transform.rotation, 0.1f);
        }

		this.GetComponentInChildren<scrPlaceCursor>().SetHands(Input.GetKey(KeyCode.W));
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
                this.transform.Rotate(Vector3.up * Time.deltaTime * 20);
            }
            else if (inputInfo.Features.Angle < -5)
            {
                //this.transform.rotation = Quaternion(0, 0, this.transform.rotation.z + inputInfo.Features.Angle, 0.1f);
                //this.transform.Rotate(Vector3.back * (inputInfo.Features.Angle / 20));
                this.transform.Rotate(Vector3.down * Time.deltaTime * 20);
            }

            //Debug.Log(inputInfo.Features.Position.y);

            if (inputInfo.Features.Position.y > playerPos + 0.05)
            {
                this.transform.Translate(0, 0, -0.05f);
            }
            else if (inputInfo.Features.Position.y < playerPos - 0.05)
            {
                this.transform.Translate(0, 0, 0.05f);
            }

            if (inputInfo.Features.DistanceBetweenHands > 0.5)
            {
                this.GetComponentInChildren<scrPlaceCursor>().SetHands(true);
            }

			//this.GetComponentInChildren<scrPlaceCursor>().SetHands(inputInfo.Features.DistanceBetweenHands > 0.7);
            //this.transform.rotation = new Quaternion(0, 0, inputInfo.Features.Angle,0);
            //Debug.Log(inputInfo.Features.Angle);

            //this.transform.forward = new Vector3(0, 0, inputInfo.Features.Direction.y) * 5;

            //if (Input.GetAxis("Joystick Right") > 0.05)
            //this.transform.forward = new Vector3(0, 0, inputInfo.Features.Direction.y) * 5;

        }

        if (kinectEnabled == true && canLock == true)
        {
            if (waitForMove == false)
            {
                StartCoroutine(waiting());
            }
            else
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

                if (inputInfo.Features.DistanceBetweenHands > 0.7)
                {
                    dial.GetComponentInParent<OpenDoor>().OpenTheDoor();
                }
                //this.transform.rotation = new Quaternion(0, 0, inputInfo.Features.Angle,0);
                Debug.Log(inputInfo.Features.Angle);
            }
        }



        return;
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(5);
        waitForMove = true;
    }
}
