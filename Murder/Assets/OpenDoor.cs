using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	public GameObject scene;
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
					if (hit.collider.tag == "DoorKitchen")
					{
						print("door tagged");
						Application.LoadLevel("Kitchen");
					}
					if (hit.collider.tag == "DoorDiningRoom")
					{
						print("door tagged");
						Application.LoadLevel("DiningRoom");
					}
					if (hit.collider.tag == "DoorDrawingRoom")
					{
						print("door tagged");
						Application.LoadLevel("DrawingRoom");
					}
					if (hit.collider.tag == "DoorLivingRoom")
					{
						print("door tagged");
						Application.LoadLevel("LivingRoom");
					}
					if (hit.collider.tag == "DoorStudy")
					{
						print("door tagged");
						Application.LoadLevel("Study");
					}
					if (hit.collider.tag == "DoorGamesRoom")
					{
						print("door tagged");
						Application.LoadLevel("GamesRoom");
					}
					if (hit.collider.tag == "DoorFoyer")
					{
						print("door tagged");
						Application.LoadLevel("CentralFoyer");
					}
					if (hit.collider.tag == "DoorWC")
					{
						print("door tagged");
						Application.LoadLevel("WC");
					}
					if (hit.collider.tag == "GroundStairs")
					{
						print("stairs tagged");
						Application.LoadLevel("UpperFoyer");
					}
					if (hit.collider.tag == "FirstStairs")
					{
						print("stairs tagged");
						Application.LoadLevel("CentralFoyer");
					}
					if (hit.collider.tag == "DoorEnsuit1")
					{
						print("door tagged");
						Application.LoadLevel("Ensuit1");
					}
					if (hit.collider.tag == "DoorEnsuit2")
					{
						print("door tagged");
						Application.LoadLevel("Ensuit2");
					}
					if (hit.collider.tag == "DoorEnsuit3")
					{
						print("door tagged");
						Application.LoadLevel("Ensuit3");
					}
					if (hit.collider.tag == "DoorGuest1")
					{
						print("door tagged");
						Application.LoadLevel("GuestRoom1");
					}
					if (hit.collider.tag == "DoorGuest2")
					{
						print("door tagged");
						Application.LoadLevel("GuestRoom2");
					}
					if (hit.collider.tag == "DoorGuest3")
					{
						print("door tagged");
						Application.LoadLevel("GuestRoom3");
					}
					if (hit.collider.tag == "DoorLibrary")
					{
						print("door tagged");
						Application.LoadLevel("Library");
					}
					if (hit.collider.tag == "DoorMasterBedroom")
					{
						print("door tagged");
						Application.LoadLevel("MasterBedroom");
					}
					if (hit.collider.tag == "DoorMasterEnsuit")
					{
						print("door tagged");
						Application.LoadLevel("MasterEnsuit");
					}
					if (hit.collider.tag == "DoorUpperFoyer")
					{
						print("door tagged");
						Application.LoadLevel("UpperFoyer");
					}
				}
			}
		}
	}
}
