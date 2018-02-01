using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour { 

	public float speed; 

	public Rigidbody2D playerrb; 

	void FixedUpdate() { 
		//Get move direction
		float move = Input.GetAxis ("Horizontal"); 
		//add velocity to the rigidbody in the move direction * our speed
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * speed, GetComponent<Rigidbody2D> ().velocity.y);
	}
}
