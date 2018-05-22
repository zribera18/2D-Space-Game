using UnityEngine;
using System.Collections;

public class audioScript : MonoBehaviour {
	public AudioClip gameOver;
	private bool musicPlay;
	// Use this for initialization
	void Start () {
		musicPlay = uiManagementScript.isGameOver;
	}

	// Update is called once per frame
	void Update () {
		AudioSource audio = GetComponent<AudioSource>();
		if ( uiManagementScript.isGameOver == true ) {
				print("HEYLLLLOOOO");
				if (musicPlay){
				audio.clip = gameOver;
				audio.Play();
				musicPlay = false;
			}
		}

		//  if ( uiManagementScript.isGameOver == false ){
		//  	  audio.clip = Resources.Load("gameSound") as AudioClip;
		//  		audio.Play();
	  // }
	}
}
