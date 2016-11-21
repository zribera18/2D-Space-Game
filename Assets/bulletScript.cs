using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {

	// Use this for initialization
	public int bulletSpeed = 800;
	void Start () {
		// Get the rigidbody component
		// Set the bullet to destroy itself after 1 seconds
		Destroy (gameObject, 10f);

		// Push the bullet in the direction it is facing
		GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
	}

	// Update is called once per frame
	void Update () {

	}
}
