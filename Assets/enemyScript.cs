using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

public GameObject breakableObject;
	public float speed;

	//public uiManagementScript x;

	// Use this for initialization
	void Start () {
		//Rigidbody2D r2d = GetComponent<Rigidbody2D>();
		speed = Random.Range(-10.0f, 10.0f) * 100;
		Destroy (gameObject, 10f);
		GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.left * speed);
	//	gameOverObjects = GameObject.FindGameObjectsWithTag("onGameOver");

	}

	void OnTriggerEnter2D(Collider2D other) {
		string name = other.gameObject.name;



	 if ( gameObject.tag == "breakable" ){
			Instantiate(breakableObject, transform.position, transform.rotation);
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Player") {
						//Destroy(other);
						uiManagementScript.isGameOver = true;
						//	x.loadGameOver();
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
