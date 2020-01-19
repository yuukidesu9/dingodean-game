using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	public float moveSpeed;//Changeable for <cheetah>.
	public float jumpHeight; //Changeable for Penny or Rocky.
	
	//Variables for ground checking. Unused for flying/winged characters.
	public Transform gndChk;
	public float gndChkRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	
	void Start () {
		
	}
	
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(gndChk.position, gndChkRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {
		//Use this part of code with flying/winged characters.
		//if(Input.GetKeyDown(KeyCode.Space)){
		//	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		//}
		if(Input.GetKeyDown(KeyCode.Space) && grounded)
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		
		if(Input.GetKey(KeyCode.D))
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		if(Input.GetKey(KeyCode.A))
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}
}
