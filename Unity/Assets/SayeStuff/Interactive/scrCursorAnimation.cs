using UnityEngine;
using System.Collections;

public class scrCursorAnimation : MonoBehaviour
{
	public float StartHeight = 0.0f;
	public float BobHeight = 1.0f;
	public float BobRate = 1.0f;
	public float TurnAngle = 1.0f;
	public float TurnRate = 1.0f;
	public float TiltAngle = 1.0f;
	public float TiltRate = 1.0f;

	private Transform model;

	void Start()
	{
		model = transform.Find ("Model");
	}

	void Update()
	{
		model.localPosition = new Vector3(0, StartHeight + BobHeight * Mathf.Sin (Time.time * BobRate), 0);
		model.localRotation = Quaternion.identity;
		model.Rotate(new Vector3(0, 1, 0), TurnAngle * Mathf.Sin (Time.time * TurnRate));
		model.Rotate(new Vector3(0, 0, 1), TiltAngle * Mathf.Sin (Time.time * TiltRate));

	}
}
