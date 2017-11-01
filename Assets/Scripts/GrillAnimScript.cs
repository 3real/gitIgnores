using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillAnimScript : MonoBehaviour {

	Animator anim;

	//Constants
	public float speed = 10;

	private Rigidbody playerRigidbody;



	void Start () {
		anim = GetComponent<Animator> ();
		playerRigidbody = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W))
		{
			anim.Play( "forward" );
			//			playerRigidbody.velocity = new Vector3(0,0,0);
			//			playerRigidbody.AddForce (new Vector3(0,speed,0), ForceMode.Impulse);

			//			playerRigidbody.AddForce (transform.forward * speed);

			//			playerRigidbody.velocity = new Vector3(speed,0, 0);
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			anim.Play( "left" );
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			anim.Play( "right" );
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			anim.Play( "back" );
		}
		//		else
		//		{
		//			anim.Play( "idle" );
		//		}
	}
}
