using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	[SerializeField]Text Score;
	int counter = 0;

	void Start () {
		
	}
	
	public void UpdateCounter () {
		counter += 1;
		Score.text = "Score: " + counter;
	}

}
