using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

Animator anim;
		
//Constants




void Start () {
		anim = GetComponent<Animator> ();
	}


// Update is called once per frame
void Update () {
		if (Input.GetKeyDown(KeyCode.W))
			{
			anim.Play( "forward" );
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
