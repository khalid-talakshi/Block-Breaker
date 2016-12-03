using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	
	private int timesHit;
	
	// Use this for initialization
	void Start () {
		
		timesHit = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	
	
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		
<<<<<<< HEAD
		maxHits --;
		
		if (maxHits == 3) {
			
			gameObject.renderer.material.color = new Color(0.604f, 0.349f, 0.710f); 
			
		} else if (maxHits == 2) {
			
			gameObject.renderer.material.color = new Color(0.180f, 0.796f, 0.439f);
			
		} else if (maxHits == 1) {
			
			gameObject.renderer.material.color = new Color(0.180f, 0.796f, 0.439f);
			
		} else if ( 0 >= maxHits) {
			
			Destroy(gameObject);
			
		}
		
		
	}
	
	//TODO Remove this method once we can actually win 0.180f, 0.796f, 0.439f
	void SimulateWin() {
		
		levelmanager.loadNextLevel();
		
=======
		timesHit ++;
>>>>>>> parent of df2b183... Added Destroy Mechanics
		
	}
}
