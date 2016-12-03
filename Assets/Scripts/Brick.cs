﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public int maxHits;
	
	private int timesHit;
	private LevelManager levelmanager; 
	
	// Use this for initialization
	void Start () {
		
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		
		timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		
		timesHit ++;
		if (timesHit >= maxHits) {
			
			Destroy(gameObject);
			
		}
		
		
	}
	
	//TODO Remove this method once we can actually win
	void SimulateWin() {
		
		levelmanager.loadNextLevel();
		
		
	}
}