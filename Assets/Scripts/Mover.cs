using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public Vector3 spawn = new Vector3();
	public float onward = 10;

	private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			myRigidbody.velocity = new Vector3 (-onward, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			myRigidbody.velocity = new Vector3 (0, 0, -onward);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			myRigidbody.velocity = new Vector3 (0, 0, onward);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			myRigidbody.velocity = new Vector3 (onward, 0, 0);
		}
		if (transform.position.y < -4) 
		{
			myRigidbody.velocity = new Vector3 (0, 0, 0);
			transform.position = spawn;
		}
	}
}
