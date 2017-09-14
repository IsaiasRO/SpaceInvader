using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private GameManager GM;
	[SerializeField] GameObject Alien;

	void Awake(){
		for (int i = -0; i < 10; i++) 
		{
			for(int i = -0)
			Instantiate	(Alien,new Vector2 (i,0),Quaternion.identity);	
		}
	}

	void Start () {
		
	}
	

	void Update () {
		
	}
}
