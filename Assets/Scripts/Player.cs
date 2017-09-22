using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private int speed = 5;
	[SerializeField]GameObject bullet;

	void Start () {
		StartCoroutine (cool ());
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
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Instantiate (bullet, transform.position, Quaternion.identity);	
			StartCoroutine (cool ());
		}

	}
	IEnumerator cool (){
		yield return new WaitForSeconds (3f);
	}
}
