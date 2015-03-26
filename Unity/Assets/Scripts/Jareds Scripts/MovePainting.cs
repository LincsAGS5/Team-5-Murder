using UnityEngine;
using System.Collections;

public class MovePainting : MonoBehaviour
{
    public int SlideOpenThePainting = 0;
    public static bool guiOn = true;
    float WaitTime = 3;
    public static int OpenthePainting = 0;
    public static int SlideShutThePainting = 0;

    public bool openPainting = false;

    void Start()
    {

    }

    void StopPainting()
    {
        SlideOpenThePainting = -200;
    }

    void StopPaintingShut()
    {
        SlideShutThePainting = -200; 
        SlideOpenThePainting = 0;
    }

    void OnMouseDown()
    {
        SlideOpenThePainting += 1;
    }

    void Update()
    {
        if (openPainting == true)
        {
            SlideOpenThePainting += 1;

            if (SlideOpenThePainting > 200)
            {
                openPainting = false;
            }
            else if (SlideOpenThePainting < 200)
            {
                transform.Translate(Vector3.right * Time.deltaTime);
            }


        }

        
        


        //if (SlideOpenThePainting >= 1)
        //{
        //    //ExamineObject.leaveButton = true;

        //    Invoke("StopPainting", 3.15f);
        //    transform.Translate(Vector3.right * Time.deltaTime);
        //}
    }
}

