using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExamineObject : MonoBehaviour {
	
	public Object SelectedObject;
	public GameObject GameLogText;

	// Use this for initialization
	void Start () {

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
					if (hit.collider.name == "Logs")
					{
						print("This object is a log.");
					}
					if (hit.collider.name == "Death1")
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
					if (hit.collider.name == "Parchment")
					{
						GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA piece of parchment which reads \"In the right hands I can help protect life but at the same time destroy life... What am I?\". Maybe this is a code for something?\n";
						SelectedObject = hit.collider.gameObject;
						Destroy (SelectedObject);
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
					if (hit.collider.name == "Book")
					{
						GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA book with the title \"Modern Warfare\". Is that a reference to something?\n";
						SelectedObject = hit.collider.gameObject;
						Destroy (SelectedObject);
					}
					if (hit.collider.name == "Painting")
					{
						GameLogText.GetComponent<Text>().text = GameLogText.GetComponent<Text>().text + "\nA crooked painting on the wall. Behind it is a safe! Now what is the combination?\n";
						SelectedObject = hit.collider.gameObject;
						Destroy (SelectedObject);
					}
				}
			}
		}
	}
}
