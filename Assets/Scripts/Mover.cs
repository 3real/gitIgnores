using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {


	public float onward = 10;

	private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {if (Input.GetKeyDown (KeyCode.W)) {
			myRigidbody.velocity = new Vector3 (onward, 0, 0);
		}
	}
}
