using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

public GameObject breakableObject;
	public float speed;

	// Use this for initialization
	void Start () {
		Rigidbody2D r2d = GetComponent<Rigidbody2D>();
		speed = Random.Range(-10.0f, 10.0f) * 100;
		Destroy (gameObject, 20f);
		GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.left * speed);
	}

	void OnTriggerEnter2D(Collider2D other) {
		string name = other.gameObject.name;

		if (other.gameObject.tag == "ammunition") {
				 			Destroy(gameObject);
							print(" ~~~~~ hit ammunition block ~~~~~");
		}
		if ( gameObject.tag == "breakable" ){
			Instantiate(breakableObject, transform.position, transform.rotation);
			Destroy(gameObject);
		}

		//if ( gameObject.tag == "")

	}

	// Update is called once per frame
	void Update () {

	}
}
