﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float moveUp = 0.0f;

//		if (Input.GetMouseButtonDown (0)) {
//			moveUp = 10.0f;
//		}
//
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}
