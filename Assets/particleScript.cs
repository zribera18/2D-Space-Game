using UnityEngine;
using System.Collections;

public class particleScript : MonoBehaviour {

	public int bulletSpeed = 800;
	void Start () {
		// Get the rigidbody component
		// Set the bullet to destroy itself after 1 seconds
		Destroy (gameObject, 10f);

		// Push the bullet in the direction it is facing
		//GetComponent<Rigidbody2D>().AddForce(transform.up * 400);
		GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
	}

	void OnTriggerEnter2D(Collider2D other) {
		string name = other.gameObject.name;



		// if (name == "enemy_big(Clone)"){
		// 	// do nothing
		// }
		//
		// if (other.gameObject.tag == "ammunition"){
		// 	Destroy(gameObject);
		//
		// }

		if (other.gameObject.tag == "ammunition") {

				 //if ( (gameObject.name != "enemy_big_breakable") && (gameObject.name.Contains("enemy"))) {
							Destroy(gameObject);
				 //}
		//	Destroy(gameObject);
			print("Destroyed particle");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
