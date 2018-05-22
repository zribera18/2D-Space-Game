using UnityEngine;
using System.Collections;

public class destructionScript : MonoBehaviour {

	public GameObject breakableObject;
	// Use this for initialization
	void Start () {

	}

	void Update() {
		if (Input.GetKeyDown("x")) {
				Instantiate(breakableObject, transform.position, transform.rotation);
				Destroy(gameObject);
		}

	}
}
