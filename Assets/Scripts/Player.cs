using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private int speed = 5;
	[SerializeField]GameObject bullet;
	bool colshoot = true;

	void Start () {
		
	}
	

	void Update () {
		
		if (Input.GetKey (KeyCode.A) && transform.position.x >-10)
		{
			transform.Translate (Vector2.left * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.D)&& transform.position.x <10)
		{
			transform.Translate (Vector2.right * Time.deltaTime * speed);
		}
		if (Input.GetKeyDown (KeyCode.Space)&& colshoot) 
		{
			Instantiate (bullet, transform.position, Quaternion.identity);
			colshoot = false;
			Invoke ("cooldown",0.5f);
		}

	}
	void cooldown(){
		colshoot = true;
	}

}
