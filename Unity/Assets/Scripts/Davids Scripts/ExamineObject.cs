using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExamineObject : MonoBehaviour {
	
	public static Object SelectedObject;
	public GameObject GameLogText;
    public GameObject ItemDescription;
    public Font largeText;
    public Font smallText;


    public static bool leaveButton = false;

    public GameObject painting;


	// Use this for initialization
	void Start () 
    {
        CameraSwitch.Lockoff = 0;
        RotateLock.guiOn = false;
        OpenDoor.guiOn = false;
        RotateLock.guiOn = false;
        OpenDoor.guiOn = false;
        leaveButton = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
		if (Input.GetMouseButtonDown(0))
<<<<<<< HEAD
		{
            Interact();
		}
	}

    public void Interact()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                if (hit.collider.name == "Chair")
                {
                    ItemDescription.GetComponent<Text>().text = "\nDining chairs surround the table in the centre.";
                }
                if (hit.collider.name == "Dinner Table")
                {
                    ItemDescription.GetComponent<Text>().text = "\nAn empty wooden dining table.";
                }
                if (hit.collider.name == "Coffee Table")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA coffee table for drinks by the fire.";
                }
                if (hit.collider.name == "Drawers")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA set of drawers filled with clothing.";
                }
                /*if (hit.collider.name == "Wine Glass")
                {
                    ItemDescription.GetComponent<Text>().text = "\nThis object is a wine glass.";
                }
                if (hit.collider.name == "Plate")
                {
                    ItemDescription.GetComponent<Text>().text = "\nThis object is a plate.";
                }*/
                if (hit.collider.name == "Couch")
                {
                    ItemDescription.GetComponent<Text>().text = "\nComfy looking living room seating.";
                }
                if (hit.collider.name == "Lamp")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA bedside lamp used for reading on a night.";
                }
                if (hit.collider.name == "Cooker")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA black, electic cooker. \nNothing's cooking in the oven.";
                }
                if (hit.collider.name == "Fridge")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA large fridge, stocked full of food.";
                }
                if (hit.collider.name == "Counter")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA polished black-stone kitchen counter. It is as clean as a whistle.";
                }
                if (hit.collider.name == "Bottom Cupboards")
                {
                    ItemDescription.GetComponent<Text>().text = "\nKitchen cupboards filled with utensils.";
                }
                if (hit.collider.name == "Sink")
                {
                    ItemDescription.GetComponent<Text>().text = "\nThe kitchen sink, made from stainless steel.";
                }
                if (hit.collider.name == "Bathroom Sink")
                {
                    ItemDescription.GetComponent<Text>().text = "\nThe bathroom sink, made from white ceramic.";
                }
                if (hit.collider.name == "Logs")
                {
                    ItemDescription.GetComponent<Text>().text = "\nExtra logs for the fire.";
                }
                /*if (hit.collider.name == "Death1")
                {
                    print("The way the body has landed suggest the victim was unaware and got hit from behind by a blunt object.");
                }
                if (hit.collider.name == "Blood Splatter")
                {
                    print("There is blood on the wall. Based on the angle of the splatter it appears the killer was taller than the victim.");
                }
                if (hit.collider.name == "Footprints")
                {
                    print("There are 2 sets of footprints. The ones behind appear to be a larger size than the ones in front.");
                }*/
                if (hit.collider.name == "Vinyl")
                {
                    ItemDescription.GetComponent<Text>().text = "\nThis object is a vinyl player.";
                }
                if (hit.collider.name == "Bookcase")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA mahogany bookcase filled with various hardback books and journals.";
                }
                /*if (hit.collider.name == "Desk")
                {
                    ItemDescription.GetComponent<Text>().text = "\nThis object is a desk.";
                }*/
                if (hit.collider.name == "Toilet")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA bright white toilet.";
                }
                if (hit.collider.name == "Bathtub")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA bright white bathtub so clean you'd question whether it was ever used.";
                }
                if (hit.collider.name == "Parchment")
                {
                    GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?\n";
                    ItemDescription.GetComponent<Text>().text = "\nA piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?\n";
                    SelectedObject = hit.collider.gameObject;
                    Destroy(SelectedObject);
                }
                if (hit.collider.name == "Bed")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA cream sheeted, king sized bed, with a dark wooden finish.";
                }
                if (hit.collider.name == "Bedside Table")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA bedside table with 3 drawers.";
                }
                if (hit.collider.name == "Wardrobe")
                {
                    ItemDescription.GetComponent<Text>().text = "\nAn extra-wide wardrobe, stocked full with clothes.";
                }
                if (hit.collider.name == "Dressing Table")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA low dressing table with a mirror.";
                }
                if (hit.collider.name == "Stool")
                {
                    ItemDescription.GetComponent<Text>().text = "\nSeating for the dressing table.";
                }
                if (hit.collider.name == "Fireplace")
                {
                    ItemDescription.GetComponent<Text>().text = "\nAn unlit fireplace sits in the centre of the wall.";
                }
                if (hit.collider.name == "Door")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA solid wooden door.";
                }
                if (hit.collider.name == "Window")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA glass paned window.";
                }
                if (hit.collider.name == "Curtains")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA set of curtains hung infront of the window.";
                }
                if (hit.collider.name == "Lamp")
                {
                    ItemDescription.GetComponent<Text>().text = "\nA set of curtains hung infront of the window.";
                }
                if (hit.collider.name == "Coat Hanger")
                {
                    ItemDescription.GetComponent<Text>().text = "\nAn empty coat hanger stood by the front door.";
                }
                if (hit.collider.name == "Book")
                {
                    GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA book with the title \"Modern Warfare\". Is that a reference to something?\n";
                    ItemDescription.GetComponent<Text>().text = "\nA book with the title \"Modern Warfare\". Is that a reference to something?";
                    SelectedObject = hit.collider.gameObject;
                    Destroy(SelectedObject);
                }
                if (hit.collider.name == "Painting")
                {
                    GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA crooked painting on the wall. Behind it is a safe! Now what is the combination?\n";
                    ItemDescription.GetComponent<Text>().text = "\nA crooked painting on the wall. Behind it is a safe! Now what is the combination?";
                    SelectedObject = hit.collider.gameObject;
                    Destroy(SelectedObject);
                }
            }
        }
=======
		{			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{					
					if (hit.collider.name == "Chair")
					{
                        ItemDescription.GetComponent<Text>().text = "\nDining chairs surround the table in the centre.";
					}
					if (hit.collider.name == "Table")
					{
                        ItemDescription.GetComponent<Text>().text = "\nAn empty wooden dining table.";
					}                
                    if (hit.collider.name == "Small Table")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA small table for drinks by the fire.";
					}
					/*if (hit.collider.name == "Wine Glass")
					{
                        ItemDescription.GetComponent<Text>().text = "\nThis object is a wine glass.";
					}
					if (hit.collider.name == "Plate")
					{
                        ItemDescription.GetComponent<Text>().text = "\nThis object is a plate.";
					}*/
					if (hit.collider.name == "Couch")
					{
                        ItemDescription.GetComponent<Text>().text = "\nComfy looking living room seating.";
					}
					if (hit.collider.name == "Cooker")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA black, electic cooker. \nNothing's cooking in the oven.";
					}
					if (hit.collider.name == "Fridge")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA large fridge, stocked full of food.";
					}
					if (hit.collider.name == "Counter")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA polished black-stone kitchen counter. It is as clean as a whistle.";
					}
                    if (hit.collider.name == "Kitchen Cupboard")
                    {
                        ItemDescription.GetComponent<Text>().text = "\nKitchen cupboards filled with utensils.";
                    }
					if (hit.collider.name == "Sink")
					{
                        ItemDescription.GetComponent<Text>().text = "\nThe kitchen sink, made from stainless steel.";
					}
					if (hit.collider.name == "Logs")
					{
                        ItemDescription.GetComponent<Text>().text = "\nExtra logs for the fire.";
					}
					/*if (hit.collider.name == "Death1")
					{
						print("The way the body has landed suggest the victim was unaware and got hit from behind by a blunt object.");
					}
					if (hit.collider.name == "Blood Splatter")
					{
						print("There is blood on the wall. Based on the angle of the splatter it appears the killer was taller than the victim.");
					}
					if (hit.collider.name == "Footprints")
					{
						print("There are 2 sets of footprints. The ones behind appear to be a larger size than the ones in front.");
					}*/
					if (hit.collider.name == "Vinyl")
					{
                        ItemDescription.GetComponent<Text>().text = "\nThis object is a vinyl player.";
					}
					if (hit.collider.name == "Bookcase")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA mahogany bookcase filled with various hardback books and journals.";
					}
					/*if (hit.collider.name == "Desk")
					{
                        ItemDescription.GetComponent<Text>().text = "\nThis object is a desk.";
					}*/
					if (hit.collider.name == "Toilet")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA bright white toilet.";
					}
					if (hit.collider.name == "Bathtub")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA bright white bathtub so clean you'd question whether it was ever used.";
					}
					if (hit.collider.name == "Parchment")
					{
						GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?\n";
                        ItemDescription.GetComponent<Text>().text = "\nA piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?\n";
                        SelectedObject = hit.collider.gameObject;
						Destroy (SelectedObject);
					}
					if (hit.collider.name == "Bed")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA cream sheeted, king sized bed, with a dark wooden finish.";
					}
					if (hit.collider.name == "Cupboard")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA hardwood cupboard filled with clothes.";
					}
                    if (hit.collider.name == "Wardrobe")
					{
                        ItemDescription.GetComponent<Text>().text = "\nAn extra-wide wardrobe, stocked full with clothes.";
					}
					if (hit.collider.name == "Dressing Table")
					{
                        ItemDescription.GetComponent<Text>().text = "\nA low dressing table with a mirror.";
					}
					if (hit.collider.name == "Stool")
					{
                        ItemDescription.GetComponent<Text>().text = "\nSeating for the dressing table.";
					}
                    if (hit.collider.name == "Fireplace")
                    {
                        ItemDescription.GetComponent<Text>().text = "\nAn unlit fireplace sits in the centre of the wall.";
                    }
                    if (hit.collider.name == "Door")
                    {
                        ItemDescription.GetComponent<Text>().text = "\nA solid wooden door.";
                    }
                    if (hit.collider.name == "Window")
                    {
                        ItemDescription.GetComponent<Text>().text = "\nA glass paned window.";
                    }
					if (hit.collider.name == "Book")
					{
						GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA book with the title \"Modern Warfare\". Is that a reference to something?\n";
                        ItemDescription.GetComponent<Text>().text = "\nA book with the title \"Modern Warfare\". Is that a reference to something?";
                        SelectedObject = hit.collider.gameObject;
						Destroy (SelectedObject);
					}
					if (hit.collider.name == "Painting")
					{
						GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA crooked painting on the wall. Behind it is a safe! Now what is the combination?\n";
                        ItemDescription.GetComponent<Text>().text = "\nA crooked painting on the wall. Behind it is a safe! Now what is the combination?";
                        SelectedObject = hit.collider.gameObject;
                        CameraSwitch.Lockoff = 1;
                        RotateLock.guiOn = true;
                        OpenDoor.guiOn = true;
                       // leaveButton = true;
                   //     MovePainting.OpenthePainting = 1;
                        //M.OpenthePainting = 1;
                        
						//Destroy (SelectedObject);

                        
					}
				}
			}
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

>>>>>>> Jareds-Newest-Branch!
    }
}
