using UnityEngine;
using System.Collections;

public class LoseColider : MonoBehaviour {

public LevelManager levelmanager;

	void OnTriggerEnter2D (Collider2D trigger) {
		
		print("Trigger");
		levelmanager.LoadLevel("Win Screen");
		
		
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
	
		print("Collision");
		
	}
}
