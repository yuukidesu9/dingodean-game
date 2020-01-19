using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
	public LevelManager levelMgr;
	// Use this for initialization
	void Start () {
		levelMgr = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	/*void OnTriggerEnter2D(Collider2D other){
		if(other.name == "char"){
			levelMgr.RespawnPlayer();
		}
	}
	Use this code with traps or any other hazards.
	Attach this script to the insta-kill hazard.*/
}
