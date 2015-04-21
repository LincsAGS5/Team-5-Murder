using UnityEngine;
using System.Collections;

public class scrPlaceCursor : MonoBehaviour
{
	const float CONTACT_OFFSET = 0.2f;
	public GameObject Cursor;
	public float Distance;
	public float Radius;

	private scrInteractive lastHighlighted;
	private bool hands = false;

	void FixedUpdate()
	{
		RaycastHit hit;

		// Raycast forwards to get the furthest distance that isn't blocked.
		float cursorDistance = Distance;
		if (Physics.Raycast(transform.position + Vector3.up * 0.5f, transform.forward, out hit, Distance))
			cursorDistance = hit.distance - CONTACT_OFFSET;

		// Raycast down to the highest point from the floor.
		Vector3 cursorPosition;
		if (Physics.Raycast(new Vector3(transform.position.x + transform.forward.x * cursorDistance, 100.0f, transform.position.z + transform.forward.z * cursorDistance), Vector3.down, out hit))
			cursorPosition = hit.point;
		else
			cursorPosition = new Vector3(transform.position.x + transform.forward.x * cursorDistance, 0.0f, transform.position.z + transform.forward.z * cursorDistance);

		Cursor.transform.position = Vector3.Lerp (Cursor.transform.position, cursorPosition, 0.6f);
		Cursor.transform.eulerAngles = new Vector3(0, Mathf.Rad2Deg * Mathf.Atan2 (cursorPosition.x - transform.position.x, cursorPosition.z - transform.position.z), 0);

		// Check if anything is within the cursor radius.
		Collider[] interactives = Physics.OverlapSphere(cursorPosition, Radius, 1 << LayerMask.NameToLayer ("Interactive"));
		if (interactives.Length != 0)
		{
			// Get the closest object to the cursor.
			float closestDistance = Radius;
			Collider closestInteractive = interactives[0];
			for (int i = 1; i < interactives.Length; ++i)
			{
				// Get the distance between the cursor and the closest point of the overlapping object and the cursor point.
				Vector3 closestPart = interactives[i].ClosestPointOnBounds(cursorPosition);
				float distance = Vector3.Distance(closestPart, cursorPosition);
				if (distance > closestDistance)
					closestInteractive = interactives[i];
			}

			// Highlight the interactive object.
			scrInteractive closestInteractiveScript = closestInteractive.GetComponent<scrInteractive>();
			if (closestInteractiveScript != lastHighlighted)
			{
				if (lastHighlighted != null)
					lastHighlighted.SetHighlight(false);	// Restore the previously highlighted object to normal.

				closestInteractiveScript.SetHighlight(true);
				lastHighlighted = closestInteractiveScript;
			}

			if (hands)
			{
				// Interact with the closest interactive object.
				ExamineObject.Instance.Interact(closestInteractive.gameObject);
				hands = false;
			}
		}
		else
		{
			if (lastHighlighted)
			{
				lastHighlighted.SetHighlight(false);	// Restore the previously highlighted object to normal.
				lastHighlighted = null;
			}
		}
	}

	public void SetHands(bool value)
	{
		hands = value;
	}
}
