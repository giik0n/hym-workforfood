using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
GameObject objUI;

void Start () {
	objUI = GameObject.Find("GameOverText");
}
	// Use this for initialization
	void OnTriggerEnter (Collider plyr) {
		if(plyr.gameObject.tag == "Player")
			objUI.GetComponent<Text>().text= "Game Over";
			SceneManager.LoadScene("MainMenu");

	}

}
