using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public GameObject enemy;
	// Use this for initialization
	void Start () {
	InvokeRepeating("spawnEnemy", 1.0f, 0.5f);
	}

	void spawnEnemy () {
			Renderer rd = GetComponent<Renderer>();

			float randoCarisian = Random.Range(-10.0f, 10.0f) * 10 - 1;

			float x1 = transform.position.y - rd.bounds.size.y/2;

			// Same for the right edge
			float x2 = transform.position.y + rd.bounds.size.y/2;

			// Randomly pick a point within the spawn object
			Vector2 spawnPoint = new Vector2(transform.position.x, Random.Range(x1, x2));

			// if (randoCarisian == 3) {
			// 		Instantiate(enemy1, spawnPoint, Quaternion.identity);
			// } else {
			// Create an enemy at the 'spawnPoint' position
					Instantiate(enemy, spawnPoint, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
					//print("instantiated ")
		//	}


	}

	// Update is called once per frame
	void Update () {

	}
}
