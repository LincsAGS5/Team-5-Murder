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
	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    public void Interact(GameObject interactive)
    {			
		if (interactive.name == "Chair")
		{
		ItemDescription.GetComponent<Text>().text = "\nDining chairs surround the table in the centre.";
		}
		if (interactive.name == "Table")
		{
		ItemDescription.GetComponent<Text>().text = "\nAn empty wooden dining table.";
		}                
		if (interactive.name == "Small Table")
		{
		ItemDescription.GetComponent<Text>().text = "\nA small table for drinks by the fire.";
		}
		/*if (interactive.name == "Wine Glass")
		{
		ItemDescription.GetComponent<Text>().text = "\nThis object is a wine glass.";
		}
		if (interactive.name == "Plate")
		{
		ItemDescription.GetComponent<Text>().text = "\nThis object is a plate.";
		}*/
		if (interactive.name == "Couch")
		{
		ItemDescription.GetComponent<Text>().text = "\nComfy looking living room seating.";
		}
		if (interactive.name == "Cooker")
		{
		ItemDescription.GetComponent<Text>().text = "\nA black, electic cooker. \nNothing's cooking in the oven.";
		}
		if (interactive.name == "Fridge")
		{
		ItemDescription.GetComponent<Text>().text = "\nA large fridge, stocked full of food.";
		}
		if (interactive.name == "Counter")
		{
		ItemDescription.GetComponent<Text>().text = "\nA polished black-stone kitchen counter. It is as clean as a whistle.";
		}
		if (interactive.name == "Kitchen Cupboard")
		{
		ItemDescription.GetComponent<Text>().text = "\nKitchen cupboards filled with utensils.";
		}
		if (interactive.name == "Sink")
		{
		ItemDescription.GetComponent<Text>().text = "\nThe kitchen sink, made from stainless steel.";
		}
		if (interactive.name == "Logs")
		{
		ItemDescription.GetComponent<Text>().text = "\nExtra logs for the fire.";
		}
		/*if (interactive.name == "Death1")
		{
			print("The way the body has landed suggest the victim was unaware and got hit from behind by a blunt object.");
		}
		if (interactive.name == "Blood Splatter")
		{
			print("There is blood on the wall. Based on the angle of the splatter it appears the killer was taller than the victim.");
		}
		if (interactive.name == "Footprints")
		{
			print("There are 2 sets of footprints. The ones behind appear to be a larger size than the ones in front.");
		}*/
		if (interactive.name == "Vinyl")
		{
		ItemDescription.GetComponent<Text>().text = "\nThis object is a vinyl player.";
		}
		if (interactive.name == "Bookcase")
		{
		ItemDescription.GetComponent<Text>().text = "\nA mahogany bookcase filled with various hardback books and journals.";
		}
		/*if (interactive.name == "Desk")
		{
		ItemDescription.GetComponent<Text>().text = "\nThis object is a desk.";
		}*/
		if (interactive.name == "Toilet")
		{
		ItemDescription.GetComponent<Text>().text = "\nA bright white toilet.";
		}
		if (interactive.name == "Bathtub")
		{
		ItemDescription.GetComponent<Text>().text = "\nA bright white bathtub so clean you'd question whether it was ever used.";
		}
		if (interactive.name == "Parchment")
		{
			GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?\n";
		ItemDescription.GetComponent<Text>().text = "\nA piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?\n";
		SelectedObject = interactive.gameObject;
			Destroy (SelectedObject);
		}
		if (interactive.name == "Bed")
		{
		ItemDescription.GetComponent<Text>().text = "\nA red sheeted, king sized bed, with a leather finish.";
		}
		if (interactive.name == "Cupboard")
		{
		ItemDescription.GetComponent<Text>().text = "\nA hardwood cupboard void of clothes.";
		}
		if (interactive.name == "Wardrobe")
		{
		ItemDescription.GetComponent<Text>().text = "\nAn extra-wide wardrobe, stocked full with clothes.";
		}
		if (interactive.name == "Dressing Table")
		{
		ItemDescription.GetComponent<Text>().text = "\nA low dressing table with a mirror.";
		}
		if (interactive.name == "Stool")
		{
		ItemDescription.GetComponent<Text>().text = "\nSeating for the dressing table.";
		}
		if (interactive.name == "Fireplace")
		{
		ItemDescription.GetComponent<Text>().text = "\nA lit fireplace sits in the centre of the wall.";
		}
		if (interactive.name == "Door")
		{
		ItemDescription.GetComponent<Text>().text = "\nA solid wooden door.";
		}
		if (interactive.name == "Window")
		{
		ItemDescription.GetComponent<Text>().text = "\nA glass paned window.";
		}
		if (interactive.name == "Book")
		{
			GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA book with the title \"Modern Warfare\". Is that a reference to something?\n";
		ItemDescription.GetComponent<Text>().text = "\nA book with the title \"Modern Warfare\". Is that a reference to something?";
		SelectedObject = interactive.gameObject;
			Destroy (SelectedObject);
		}
		if (interactive.name == "Painting")
		{
			GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA crooked painting on the wall. Behind it is a safe! Now what is the combination?\n";
		ItemDescription.GetComponent<Text>().text = "\nA crooked painting on the wall. Behind it is a safe! Now what is the combination?";
		SelectedObject = interactive.gameObject;
		//CameraSwitch.Lockoff = 1;
		//RotateLock.guiOn = true;
		//OpenDoor.guiOn = true;



		pm.canLock = true;
		pm.canMove = false;

		lc.enabled = true;

		mp.openPainting = true;


		// leaveButton = true;
		//     MovePainting.OpenthePainting = 1;
		//M.OpenthePainting = 1;

			//Destroy (SelectedObject);


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
