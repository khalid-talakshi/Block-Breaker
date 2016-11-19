﻿using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public Paddle paddle; 
	
	private Vector3 paddleToBallVector;
	
	private bool gameStart = false;

	// Use this for initialization
	void Start () {
	
		paddleToBallVector = this.transform.position - paddle.transform.position;
		print (paddleToBallVector);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!gameStart) {
			// Lock the ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			//wait for a mouse press relative to the launch
			if (Input.GetMouseButtonDown(0)) {
				print("Mouse Button Clicked");
				gameStart = true;
				this.rigidbody2D.velocity =  new Vector2(5f, 5f);	
			}
		}
		
		
	
	}
}