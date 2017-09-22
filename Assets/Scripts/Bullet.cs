using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	private float speed = 5;
	private Transform bullet;
	[SerializeField] UIManager uimanager;

	void Start () {
		
		bullet = GetComponent <Transform> ();
	}
	

	void Update () {
		uimanager = GameObject.FindObjectOfType<UIManager>();
		transform.Translate (Vector3.up * speed * Time.deltaTime);
		if(bullet.position.y >10){
			Destroy (gameObject);
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
			uimanager.UpdateCounter ();
			Destroy (gameObject);
		}
	}
}
