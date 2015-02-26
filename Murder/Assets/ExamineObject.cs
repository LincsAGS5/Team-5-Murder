using UnityEngine;
using System.Collections;

public class ExamineObject : MonoBehaviour {
	
	public Object SelectedObject;
	public bool addInventory;
	public GameObject KeepOnLoad;
	public GameObject Bookcase;
	public bool BookcaseTagged;
	Vector3 start;
	Vector3 end;
	// Use this for initialization
	void Start () {
		addInventory = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider != null)
				{					
					if (hit.collider.name == "Chair")
					{
						print("This object is a chair.");
					}
					if (hit.collider.name == "Table")
					{
						print("This object is a table.");
					}
					if (hit.collider.name == "Wine Glass")
					{
						print("This object is a wine glass.");
					}
					if (hit.collider.name == "Plate")
					{
						print("This object is a plate.");
					}
					if (hit.collider.name == "Cracked Plate")
					{
						print("This object is a cracked plate.");
						print("You add cracked plate to your inventory.");
						addInventory = true;
						SelectedObject = hit.collider.gameObject;
						KeepOnLoad.GetComponent<KeepOnLoad> ().CrackedPlate = true;
						Destroy(SelectedObject);
						print("Item has been removed from scene.");
					}
					if (hit.collider.name == "Piano")
					{
						print("This object is a piano.");
					}
					if (hit.collider.name == "Couch")
					{
						print("This object is a couch.");
					}
					if (hit.collider.name == "Cooker")
					{
						print("This object is a cooker.");
					}
					if (hit.collider.name == "Fridge")
					{
						print("This object is a fridge.");
					}
					if (hit.collider.name == "Counter")
					{
						print("This object is a counter.");
					}
					if (hit.collider.name == "Sink")
					{
						print("This object is a sink.");
					}
					if (hit.collider.name == "Snooker Table")
					{
						print("This object is a snooker table.");
					}
					if (hit.collider.name == "Logs")
					{
						print("This object is a log.");
					}
					if (hit.collider.name == "Death1")
					{
						print("The way the body has landed suggest the victim was unaware and got hit from behind by a blunt object.");
						KeepOnLoad.GetComponent<KeepOnLoad> ().Maid = true;
					}
					if (hit.collider.name == "Blood Splatter")
					{
						print("There is blood on the wall. Based on the angle of the splatter it appears the killer was taller than the victim.");
						KeepOnLoad.GetComponent<KeepOnLoad> ().BloodSplatter = true;
					}
					if (hit.collider.name == "Footprints")
					{
						print("There are 2 sets of footprints. The ones behind appear to be a larger size than the ones in front.");
						KeepOnLoad.GetComponent<KeepOnLoad> ().Footprints = true;
					}
					if (hit.collider.name == "Vinyl")
					{
						print("This object is a vinyl player.");
					}
					if (hit.collider.name == "Bookcase")
					{
						print("This object is a bookcase.");
					}
					if (hit.collider.name == "Desk")
					{
						print("This object is a desk.");
					}
					if (hit.collider.name == "Toilet")
					{
						print("This object is a toilet.");
					}
					if (hit.collider.name == "Bathtub")
					{
						print("This object is a bathtub.");
					}
					if (hit.collider.name == "Shower")
					{
						print("This object is a shower.");
					}
					if (hit.collider.name == "Parchment")
					{
						print("A piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?");
						print("Hit enter to add parchment to your inventory.");
						addInventory = true;
						SelectedObject = hit.collider.gameObject;
						KeepOnLoad.GetComponent<KeepOnLoad> ().Parchment = true;
						Destroy(SelectedObject);
						print("Item has been removed from scene.");
					}
					if (hit.collider.tag == "Bookcase")
					{
						print("Bookcase Tagged.");
						Bookcase = hit.collider.gameObject;
						BookcaseTagged = true;
						start = Bookcase.transform.position;
						end = new Vector3(start.x + 5, start.y, start.z); 
					}
					if (hit.collider.name == "Knife")
					{
						print("This object is a knife covered in blood, it must be one of the murder weapons!");
						print("You add knife to your inventory.");
						addInventory = true;
						SelectedObject = hit.collider.gameObject;
						KeepOnLoad.GetComponent<KeepOnLoad> ().Knife = true;
						Destroy(SelectedObject);
						print("Item has been removed from scene.");
					}
					if (hit.collider.name == "Bed")
					{
						print("This object is a bed.");
					}
					if (hit.collider.name == "Cupboard")
					{
						print("This object is a cupboard.");
					}
					if (hit.collider.name == "Dressing Table")
					{
						print("This object is a dressing table.");
					}
					if (hit.collider.name == "Stool")
					{
						print("This object is a stool.");
					}
				}
			}
		}
		if (BookcaseTagged == true) 
		{
			Bookcase.transform.position = Vector3.Lerp(Bookcase.transform.position, end, Time.deltaTime);
		}

	}
}
