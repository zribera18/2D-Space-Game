using UnityEngine;
using System.Collections;

public class spaceshipScript : MonoBehaviour {
	public GameObject bullet;
	public float rotationSpeed = 400.0f;
	//public int speed = 100;
	public Vector2 speed = new Vector2( 0f, 10.0F);
	//public Transform target; // set to the Player GameObject
	public Vector2 worldPosMin = new Vector2(-14f,-14f);
	public Vector2 worldPosMax = new Vector2(14f, 14f);

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//float dx = Input.GetAxis("Horizontal");
		//float dy = Input.GetAxis("Vertical");

		//GetComponent<Rigidbody2D>().velocity = new Vector2(dx * speed, dy * speed) * Time.deltaTime;

		//Vector3 move = Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		//transform.position += move * speed * Time.deltaTime;

		// float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		// rotation *= Time.deltaTime;
		// transform.Rotate(0, 0 , -rotation);

		// if ( Input.GetAxis("Horizontal") > 0){
		// 	Vector2 translation = Input.GetAxis("Horizontal") * rotationSpeed;
		// 	rotation *= Time.deltaTime;
		//
		// }

		//Translation is an special case, only occurs if the player wants to go up!
		// if( Input.GetAxis("Vertical") > 0 ){
		// 	Vector2 translation = Input.GetAxis("Vertical") * speed;
		// 	translation *= Time.deltaTime;
		// 	GetComponent<Rigidbody2D>().AddRelativeForce(translation, ForceMode2D.Impulse);
		// }
		//
		// if( Input.GetAxis("Vertical") <= 0 ){
		// 	Vector2 translation = Input.GetAxis("Vertical") * speed;
		// 	translation *= Time.deltaTime;
		// 	GetComponent<Rigidbody2D>().AddRelativeForce(translation, ForceMode2D.Impulse);
		// }

		// float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		// rotation *= Time.deltaTime;
		// transform.Rotate(0, 0 , -rotation);

		 if( Input.GetAxis("Horizontal") < 0 ){
		 	Vector2 translation = Input.GetAxis("Horizontal") * speed;
		 	translation *= Time.deltaTime;
		 	GetComponent<Rigidbody2D>().AddRelativeForce( transform.right, ForceMode2D.Impulse);
		 }

		if( Input.GetAxis("Horizontal") > 0 ){
			Vector2 translation = Input.GetAxis("Horizontal") * speed;
			translation *= Time.deltaTime;
			GetComponent<Rigidbody2D>().AddRelativeForce( -transform.right, ForceMode2D.Impulse);
		}

		//Translation is an special case, only occurs if the player wants to go up!
		if( Input.GetAxis("Vertical") < 0 ){
			Vector2 translation = Input.GetAxis("Vertical") * speed;
			translation *= Time.deltaTime;
			GetComponent<Rigidbody2D>().AddRelativeForce( transform.up, ForceMode2D.Impulse);
		}

		if( Input.GetAxis("Vertical") > 0 ){
			Vector2 translation = Input.GetAxis("Vertical") * speed;
			translation *= Time.deltaTime;
			GetComponent<Rigidbody2D>().AddRelativeForce(-transform.up, ForceMode2D.Impulse);
		}

		// When the spacebar is pressed
		if (Input.GetKeyDown("space")) {
			Instantiate(bullet, new Vector2(transform.position.x,transform.position.y), transform.rotation);
		}

		 Vector3 targetPos = gameObject.transform.position;
		 targetPos.y = Mathf.Clamp(transform.position.y, -13.75f, 13.75f);
		 transform.position = targetPos;
		 print("targetPos: " + targetPos);
		//  if (targetPos.y  > 12){
		// 	 GetComponent<Rigidbody2D>().transform.position = new Vector3(targetPos.x, 12, transform.position.z);
		//  }
		//  float x = Mathf.Clamp(targetPos.x, worldPosMin.x, worldPosMax.x);
		//  float y = Mathf.Clamp(targetPos.y, worldPosMin.y, worldPosMax.y);

		 //GetComponent<Rigidbody2D>().transform.position = new Vector3(x, y, transform.position.z);

	}
}
