using UnityEngine;
using System.Collections;

public class RotateLock : MonoBehaviour
{



    bool rotateRight = false;
    bool rotateLeft = false;
    public float codeHelper = 100;
    public float code = 1;
    public bool codeNum1 = false;
    public bool codeNum2 = false;
    public bool codeNum3 = false;
    public GameObject dial;
    bool guiOn = true;

    // Use this for initialization
    void Start()
    {

    }

    void ButtonReappear()
    {
        
            guiOn = true;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (rotateRight == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 7.60f);
         
        }

        if (rotateLeft == true)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 7.60f);
            

        }


        if (codeHelper == 100)
        {
            code = 0;
        }

        if (codeHelper == 101)
        {
            code = 1;
        }
        if (codeHelper == 102)
        {
            code = 2;
        }
        if (codeHelper == 103)
        {
            code = 3;
        }
        if (codeHelper == 104)
        {
            code = 4;
        }
        if (codeHelper == 105)
        {
            code = 5;
        }
        if (codeHelper == 106)
        {
            code = 6;
        }
        if (codeHelper == 107)
        {
            code = 7;
        }
        if (codeHelper == 108)
        {
            code = 8;
        }
        if (codeHelper == 109)
        {
            code = 9;
        }

        if (codeHelper == 99)
        {
            code = 9;
        }
        if (codeHelper == 98)
        {
            code = 8;
        }
        if (codeHelper == 97)
        {
            code = 7;
        }
        if (codeHelper == 96)
        {
            code = 6;
        }
        if (codeHelper == 95)
        {
            code = 5;
        }
        if (codeHelper == 94)
        {
            code = 4;
        }
        if (codeHelper == 93)
        {
            code = 3;
        }
        if (codeHelper == 92)
        {
            code = 2;
        }
        if (codeHelper == 91)
        {
            code = 1;
        }

        if (codeHelper == 90)
        {
            code = 0;
        }

    }


    void stopRotate()
    {
        rotateRight = false;
        rotateLeft = false;
    }


    void OnGUI()
    {


        if (guiOn == true)
        {

            if (GUI.Button(new Rect(320, 630, 110, 30), "Rotate Right"))
            {
                rotateRight = true;
                rotateLeft = false;

                Invoke("stopRotate", 1.445f);
                guiOn = false;

                Invoke("ButtonReappear", 1.35f);

                codeHelper += 1;

                if (codeHelper > 109)
                {
                    codeHelper = 100;
                }

            }

            if (GUI.Button(new Rect(60, 630, 110, 30), "Rotate Left"))
            {
                rotateLeft = true;
                rotateRight = false;
                Invoke("stopRotate", 1.445f);

                guiOn = false;
                Invoke("ButtonReappear", 1.35f);

                codeHelper -= 1;


                if (codeHelper <= 90)
                {
                    codeHelper = 100;
                }

            }
        }

        GUI.Label(new Rect(190, 500, 110, 30), "Code is: 10, 40, 70");

        if (guiOn == true)
        {

            if (GUI.Button(new Rect(190, 580, 110, 30), "Log Number"))
            {
                if (code == 1)
                {
                    codeNum1 = true;
                }
                if (code == 4)
                {
                    codeNum2 = true;
                }
                if (code == 7)
                {
                    codeNum3 = true;
                }


                if (codeNum1 == true && codeNum2 == true && codeNum3 == true)
                {
                    dial.GetComponentInParent<OpenDoor>().OpenTheDoor();

                }


                if (code == 0 || code == 2 || code == 3 || code == 5 || code == 6 || code == 8 || code == 9)
                {

                    codeNum1 = false;
                    codeNum2 = false;
                    codeNum3 = false;



                }
            }
        }

    }
}