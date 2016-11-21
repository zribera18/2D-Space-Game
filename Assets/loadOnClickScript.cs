using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class loadOnClickScript : MonoBehaviour {
GameObject[] pauseObjects;
	// Use this for initialization
	public void LoadScene(int level)
    {
        SceneManager.LoadScene (level);

    }

		//hides objects with ShowOnPause tag
		public void hidePaused(){
			pauseObjects = GameObject.FindGameObjectsWithTag("onPause");
			foreach(GameObject g in pauseObjects){
				g.SetActive(false);
			}
		}

		public void resume() {
			print ("helooooo");
			Time.timeScale = 1;
			hidePaused();
		}


    public void fin(int ignoreLevel)
    {
        Debug.Log("quit called");

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
                // set the PlayMode to stop
        #else
         Application.Quit();
        #endif
    }
}
