using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour {
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
			levelMgr.currentCheckpoint = gameObject;
			Debug.Log("Checkpoint! Position " + transform.position);
		}
	}
	*/
}
