using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public GameObject currentCheckpoint;
	private PlayerControl player;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void PlayerHurt(){
		//Decreases percentage from health.
	}
	public void RespawnPlayer(){
		Debug.Log("Whoops-a-daisy. You died.");
		//Set trigger and play death animation.
		//Subtract number of lives by 1.
		//Fade out.
		//Spawn player into last checkpoint, or level start.
		player.transform.position = currentCheckpoint.transform.position;
		//Fade in.
	}
}
