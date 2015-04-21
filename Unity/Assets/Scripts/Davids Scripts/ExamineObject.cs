using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExamineObject : MonoBehaviour {

	public static ExamineObject Instance { get; private set; }
	public static Object SelectedObject;
	public GameObject GameLogText;
    public GameObject ItemDescription;
    public Font largeText;
    public Font smallText;

    PlayerMove pm;
    Camera lc;
    MovePainting mp;


    public static bool leaveButton = false;

    public GameObject painting;

	private Transform notebook;
	private bool notebookRising = false;
	private float notebookRiseTimer = 0.0f;
	private float notebookRiseDuration = 0.5f;
	private float notebookStayTimer = 0.0f;
	private float notebookStayDuration = 5.0f;


	// Use this for initialization
	void Start () 
    {
		Instance = this;
        CameraSwitch.Lockoff = 0;
        RotateLock.guiOn = false;
        OpenDoor.guiOn = false;
        RotateLock.guiOn = false;
        OpenDoor.guiOn = false;
        leaveButton = false;

        pm = GameObject.Find("Player").GetComponent<PlayerMove>();
        lc = GameObject.Find("Lock Camera").GetComponent<Camera>();
		mp = GameObject.Find("Painting").GetComponent<MovePainting>();
		notebook = GameObject.Find ("Notebook").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
		// Raise or lower the notebook depending on the timer.
		notebook.localEulerAngles = new Vector3(0.0f, 0.0f, Mathf.SmoothStep(40.0f, 0.0f, notebookRiseTimer / notebookRiseDuration));
		notebook.localPosition = new Vector3(notebook.localPosition.x,
		                                     Mathf.SmoothStep(-250.0f,  50.0f, notebookRiseTimer / notebookRiseDuration),
		                                     notebook.localPosition.z);

		// Raise or lower the notebook timer.
		if (notebookRising)	// This value automatically becomes false but if the player is constantly interacting it will remain true.
		{
			// Raise to top.
			notebookRiseTimer += Time.deltaTime;
			if (notebookRiseTimer >= notebookRiseDuration)
			{
				notebookRiseTimer = notebookRiseDuration;
				notebookRising = false;
			}
		}
		else
		{
			// Lower to bottom.
			if (notebookRiseTimer > 0.0f)
			{
				if (notebookStayTimer >= notebookStayDuration)
				{
					notebookRiseTimer -= Time.deltaTime;
				}
				else
				{
					notebookStayTimer += Time.deltaTime;
				}
			}
		}
	}

    public void Interact(GameObject interactive)
    {			
		notebookRising = true;
		notebookStayTimer = 0.0f;
		ItemDescription.GetComponent<Text>().text = interactive.GetComponent<scrInteractive>().Information;

		if (interactive.name == "Parchment")
		{
			
			string text = "\nThere is a piece of paper which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something.\n";
			if (!GameLogText.GetComponent<Text>().text.Contains(text))
				GameLogText.GetComponent<Text>().text += text;
			SelectedObject = interactive.gameObject;
			Destroy (SelectedObject);
		}
		else if (interactive.name == "Book")
		{
			string text = "\nThere is a book with the title \"Modern Warfare\". Is that a reference to something?\n";
			if (!GameLogText.GetComponent<Text>().text.Contains(text))
				GameLogText.GetComponent<Text>().text += text;
			SelectedObject = interactive.gameObject;
			Destroy (SelectedObject);
		}
		else if (interactive.name == "Painting")
		{
			string text =  "\nThere is a crooked painting on the wall. Behind it is a safe! Now what is the combination?\n";
			if (!GameLogText.GetComponent<Text>().text.Contains(text))
				GameLogText.GetComponent<Text>().text += text;
			SelectedObject = interactive.gameObject;

			pm.canLock = true;
			pm.canMove = false;
			lc.enabled = true;
			mp.openPainting = true;
		}
	}

    void OnGUI()
    {
        if (leaveButton == true)
        {

            GUI.skin.font = largeText;
            if (GUI.Button(new Rect(175, 390, 150, 60), "Leave the Safe"))
            {
                CameraSwitch.Lockoff = 0;
                RotateLock.guiOn = false;
                OpenDoor.guiOn = false;
                MovePainting.SlideShutThePainting += 1;
                GUI.skin.font = smallText;
                leaveButton = false;

            }
        }

    }
}
