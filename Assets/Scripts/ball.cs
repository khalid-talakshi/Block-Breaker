using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	private Paddle paddle; 
	
	private Vector3 paddleToBallVector;
	
	private bool gameStart = false;

	// Use this for initialization
	void Start () {
		
		paddle = GameObject.FindObjectOfType<Paddle>();
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
				this.rigidbody2D.velocity =  new Vector2(7f, 7f);	
			}
		}
		
		
	
	}
}
