using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FirstFloor : MonoBehaviour {

	// Use this for initialization

public void isTrigger(){
	SceneManager.LoadScene("Basement");
}
public void OnTriggerEnter (Collider plyr) {
	if(plyr.gameObject.tag == "Player")
		SceneManager.LoadScene("Basement");

}

}
