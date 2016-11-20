using UnityEngine;
using System.Collections;

public class LoseColider : MonoBehaviour {

private LevelManager levelmanager;

	void Start() {
	
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	
	}

	void OnTriggerEnter2D (Collider2D trigger) {
			
		print("Trigger");
		levelmanager.LoadLevel("Lose Screen");
		
		
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
	
		print("Collision");
		
	}
}
