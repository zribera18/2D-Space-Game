using UnityEngine;
using System.Collections;

public class destructionScript : MonoBehaviour {

	public GameObject breakableObject;
	// Use this for initialization
	void Start () {

	}

	void Update() {
		if (Input.GetKeyDown("x")) {
				print("yoooooo");
				Instantiate(breakableObject, transform.position, transform.rotation);
				//GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
				Destroy(gameObject);
		}
	// When the spacebar is pressed

	 // Create a new bullet at “transform.position”
	 // Which is the current position of the ship
	 // Quaternion.identity = add the bullet with no rotation
	// Instantiate(bullet, new Vector2(transform.position.x,transform.position.y), transform.rotation);
	}
}
