using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	private GameManager GM;
	[SerializeField] GameObject Alien;


	void Awake(){
		for (int y = 4; y>0; y--) {

			for (int x = -5; x < 5; x++) {
				Instantiate	(Alien, new Vector2 (x, y), Quaternion.identity);	
			}
		}
	}

	void Start () {
		
	}
	


}
