using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class loadOnClickScript : MonoBehaviour {

	// Use this for initialization
	public void LoadScene(int level)
    {
        SceneManager.LoadScene (level);
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
