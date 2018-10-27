using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountObjects : MonoBehaviour {
	public string nextLevel;
	public GameObject objToDestroy;
	GameObject objUI;

	// Use this for initialization
	void Start () {
		objUI = GameObject.Find("ObjectNum");
	}

	// Update is called once per frame
	void Update () {
        	if(ObjectsToCollect.objects < 0) return;

		objUI.GetComponent<Text>().text = ObjectsToCollect.objects.ToString();
		if(ObjectsToCollect.objects == 0){
				//Application.LoadLevel(nextLevel);
				SceneManager.LoadScene("Final Scene");
			objUI.GetComponent<Text>().text= "All objects collected.";
		}
	}
}
