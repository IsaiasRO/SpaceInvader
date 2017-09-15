using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private GameManager GM;
	[SerializeField] GameObject Alien;

	void Awake(){
		for (int i = -5; i < 5; i++) 
		{
			Instantiate	(Alien,new Vector2 (i,0),Quaternion.identity);	
		}
	}

	void Start () {
		
	}
	

	void Update () {
		
	}
}
