using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class uiManagementScript : MonoBehaviour {

	GameObject[] pauseObjects;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("onPause");
		hidePaused();
	}

	//shows objects with ShowOnPause tag
	void showPaused(){

		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
		{
			print("hello!");
			if ( Time.timeScale == 1 ) {
				print( "PAUSED");
					Time.timeScale = 0;
					showPaused();
			} else if (Time.timeScale == 0) {
				print ("Resume");
				Time.timeScale = 1;
				hidePaused();
			}
	}
}

}
