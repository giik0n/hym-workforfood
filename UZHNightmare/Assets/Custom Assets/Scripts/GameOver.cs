using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {
GameObject objUI;

void Start () {
	objUI = GameObject.Find("GameOverText");
}
	// Use this for initialization
	void OnTriggerEnter (Collider plyr) {
		if(plyr.gameObject.tag == "Player")
			objUI.GetComponent<Text>().text= "Game Over";
		
	}
}
