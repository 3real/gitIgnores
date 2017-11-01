using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrillMover : MonoBehaviour {

	public Vector3 spawn = new Vector3();
	public float onward = 10;
	public int grillStartingHealth = 100;
	public int grillCurrentHealth;
	public Slider GrillFulfilmentBar;


	private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
		grillCurrentHealth = grillStartingHealth;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			myRigidbody.velocity = new Vector3 (-onward, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			myRigidbody.velocity = new Vector3 (0, 0, -onward);
			grillCurrentHealth += 10;
			GrillFulfilmentBar.value = grillCurrentHealth;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			myRigidbody.velocity = new Vector3 (0, 0, onward);
			grillCurrentHealth -= 10;
			GrillFulfilmentBar.value = grillCurrentHealth;
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