using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	[SerializeField] float speed = 5;

	void Start () {
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.velocity  = new Vector2 (0, 1) * speed;
	}
	

	void Update () {
		
	}
}
