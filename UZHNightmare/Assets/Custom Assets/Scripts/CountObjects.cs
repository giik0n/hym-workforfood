using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountObjects : MonoBehaviour {
	public string nextLevel;
	public GameObject objToDestroy;
	GameObject objUI,timeUI;
	public AudioSource audioSource;

	float timeLeft = 10;//10 * 60.0f;

	// Use this for initialization
	void Start () {
		objUI = GameObject.Find("ObjectNum");
		timeUI = GameObject.Find("TimeText");
	}

	// Update is called once per frame
	void Update () {
		         timeLeft -= Time.deltaTime;

						 float minutes = Mathf.Round(timeLeft / 60);
     	 			 float seconds = Mathf.Round(timeLeft%60);

						 timeUI.GetComponent<Text>().text = "Time " + minutes +":"+seconds;

		         if(timeLeft < 0)
		         {
							 timeUI.GetComponent<Text>().text = "Time is out!";
							 SceneManager.LoadScene("FirstFlour");
		         }

        	if(ObjectsToCollect.objects < 0) return;

		objUI.GetComponent<Text>().text = "Count of Pumpkins " + ObjectsToCollect.objects.ToString();
		if(ObjectsToCollect.objects == 0){
				//Application.LoadLevel(nextLevel);
				audioSource.Stop();
				SceneManager.LoadScene("Final Scene");
			objUI.GetComponent<Text>().text= "All pumpkins is collected.";
		}
	}
}
