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
    public static bool guiOn = true;
	float rotationIncrease = 0.0175f;
	public float rotationStart = 9.25f;
	public Font largeText;
	public Font smallText;

	public AudioSource[] sounds;
	public AudioSource noise1;
	public AudioSource noise2;
	public AudioSource noise3;


    // Use this for initialization
    void Start()
    {
		sounds = GetComponents<AudioSource>();
		noise1 = sounds[0];
		noise2 = sounds[1];
		noise3 = sounds[2];
    }

    void ButtonReappear()
    {
        
            guiOn = true;
        

    }

    void OnMouseEnter()
    {
        CameraSwitch.Lockoff = 1;
        RotateLock.guiOn = true;
        OpenDoor.guiOn = true;
        ExamineObject.leaveButton = true;
    }

 

    // Update is called once per frame
    void Update()
    {
        if (rotateRight == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotationStart);
         
        }

        if (rotateLeft == true)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotationStart);
            

        }


       if (codeHelper == 100)
		{
			code = 1;
		}

        if (codeHelper == 101)
        {
            code = 2;
        }
        if (codeHelper == 102)
        {
            code = 3;
        }
        if (codeHelper == 103)
        {
            code = 4;
        }
        if (codeHelper == 104)
        {
            code = 5;
        }
        if (codeHelper == 105)
        {
            code = 6;
        }
        if (codeHelper == 106)
        {
            code = 7;
        }
        if (codeHelper == 107)
        {
            code = 8;
        }
        if (codeHelper == 108)
        {
            code = 9;
        }
        if (codeHelper == 109)
        {
            code = 10;
        }
		if (codeHelper == 110)
		{
			code = 11;
		}
		if (codeHelper == 111)
		{
			code = 12;
		}
		if (codeHelper == 112)
		{
			code = 13;
		}
		if (codeHelper == 113)
		{
			code = 14;
		}
		if (codeHelper == 114)
		{
			code = 15;
		}
		if (codeHelper == 115)
		{
			code = 16;
		}
		if (codeHelper == 116)
		{
			code = 17;
		}
		if (codeHelper == 117)
		{
			code = 18;
		}
		if (codeHelper == 118)
		{
			code = 19;
		}
		if (codeHelper == 119)
		{
			code = 20;
		}
		if (codeHelper == 120)
		{
			code = 21;
		}
		if (codeHelper == 121)
		{
			code = 22;
		}
		if (codeHelper == 122)
		{
			code = 23;
		}
		if (codeHelper == 123)
		{
			code = 24;
		}
		if (codeHelper == 124)
		{
			code = 25;
		}
		if (codeHelper == 125)
		{
			code = 26;
		}



        if (codeHelper == 99)
        {
            code = 26;
        }
        if (codeHelper == 98)
        {
            code = 25;
        }
        if (codeHelper == 97)
        {
            code = 24;
        }
        if (codeHelper == 96)
        {
            code = 23;
        }
        if (codeHelper == 95)
        {
            code = 22;
        }
        if (codeHelper == 94)
        {
            code = 21;
        }
        if (codeHelper == 93)
        {
            code = 20;
        }
        if (codeHelper == 92)
        {
            code = 19;
        }
        if (codeHelper == 91)
        {
            code = 18;
        }

        if (codeHelper == 90)
        {
            code = 17;
        }

		if (codeHelper == 89)
		{
			code = 16;
		}
		if (codeHelper == 88)
		{
			code = 15;
		}
		if (codeHelper == 87)
		{
			code = 14;
		}
		if (codeHelper == 86)
		{
			code = 13;
		}
		if (codeHelper == 85)
		{
			code = 12;
		}
		if (codeHelper == 84)
		{
			code = 11;
		}
		if (codeHelper == 83)
		{
			code = 10;
		}
		if (codeHelper == 82)
		{
			code = 9;
		}
		if (codeHelper == 81)
		{
			code = 8;
		}
		if (codeHelper == 80)
		{
			code = 7;
		}
		if (codeHelper == 79)
		{
			code = 6;
		}
		if (codeHelper == 78)
		{
			code = 5;
		}
		if (codeHelper == 77)
		{
			code = 4;
		}
		if (codeHelper == 76)
		{
			code = 3;
		}
		if (codeHelper == 75)
		{
			code = 2;
		}
		if (codeHelper == 74)
		{
			code = 1;
		}

    }


    void stopRotate()
    {
        rotateRight = false;
        rotateLeft = false;
    }

    public void RotateLeft()
    {
<<<<<<< HEAD:Unity/Assets/JaredsStuff/Scripts/RotateLock.cs
        rotateLeft = true;
        rotateRight = false;
        Invoke("stopRotate", 1.445f);

        guiOn = false;
        Invoke("ButtonReappear", 1.35f);
        rotationStart += rotationIncrease;
=======
		

        if (guiOn == true)
        {
            GUI.contentColor = Color.black; 

            GUI.skin.font = largeText;

            GUI.Label(new Rect(170, 250, 200, 100), "Your Hovering over Code Number: " + code.ToString());
            GUI.skin.font = smallText;

            

            GUI.Label(new Rect(120, 500, 340, 30), "This is just for demostration: Code is: 7, 21, 14");

            GUI.contentColor = Color.white; 
>>>>>>> Jareds-Newest-Branch!:Unity/Assets/Scripts/Jareds Scripts/RotateLock.cs

        codeHelper -= 1;


        if (codeHelper < 75)
        {
            codeHelper = 100;
        }
        noise1.Play();
    }

    public void RotateRight()
    {

        rotateRight = true;
        rotateLeft = false;

        Invoke("stopRotate", 1.445f);
        guiOn = false;

        Invoke("ButtonReappear", 1.35f);
        rotationStart += rotationIncrease;

        codeHelper += 1;

        if (codeHelper > 125)
        {
            codeHelper = 100;
        }


        //this.GetComponent<AudioSource>().Play();
        noise1.Play();


        //audio.PlayOneShot(clickSound, 0.9f);

    }


    void OnGUI()
    {
		GUI.skin.font = largeText;
		GUI.Label(new Rect(150,300,200,100), "Your Hovering over Code Number: " + code.ToString());
		GUI.skin.font = smallText;

        if (guiOn == true)
        {

            if (GUI.Button(new Rect(320, 630, 110, 30), "Rotate Right"))
            {
                RotateRight();
            }

            if (GUI.Button(new Rect(60, 630, 110, 30), "Rotate Left"))
            {
                RotateLeft();
            }
        }

       

        if (guiOn == true)
        {


            if (GUI.Button(new Rect(190, 580, 110, 30), "Log Number"))
            {



                if (code == 7)
                {
                    codeNum1 = true;
					noise2.Play();
                }
                if (code == 21 && codeNum1 == true)
                {
                    codeNum2 = true;
					noise2.Play();
                }
				if (code == 14 && codeNum2 == true)
                {
                    codeNum3 = true;
					noise2.Play();
                }
				if (code == 21 )
				{

					noise3.Play();
				}
				if (code == 14)
				{

					noise3.Play();
				}
				if (code == 14 && codeNum1 == true && codeNum2 == false)
				{
					noise3.Play();
					codeNum1 = false;
				}




                if (codeNum1 == true && codeNum2 == true && codeNum3 == true)
                {
                    dial.GetComponentInParent<OpenDoor>().OpenTheDoor();

                }


				if (code == 0 || code == 2 || code == 3 || code == 5 || code == 6 || code == 8 || code == 9 || code == 10 || code == 11 || code == 12 || code == 13 || code == 4 || code == 15 || code == 16 || code == 17 || code == 18 || code == 19 || code == 20 || code == 1 || code == 22 || code == 23 || code == 24 || code == 25 || code == 26)
                {

                    codeNum1 = false;
                    codeNum2 = false;
                    codeNum3 = false;
					noise3.Play ();



                }
            }
        }

    }
}