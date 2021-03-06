﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mover : MonoBehaviour {

	public Vector3 spawn = new Vector3();
	public float onward = 10;
	public int startingHealth = 100;
	public int currentHealth;
	public Slider PlayerFulfilmentBar;


	private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			myRigidbody.velocity = new Vector3 (-onward, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			myRigidbody.velocity = new Vector3 (0, 0, -onward);
			currentHealth -= 10;
			PlayerFulfilmentBar.value = currentHealth;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			myRigidbody.velocity = new Vector3 (0, 0, onward);
			currentHealth += 10;
			PlayerFulfilmentBar.value = currentHealth;
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
