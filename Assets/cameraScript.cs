using UnityEngine;

using System.Collections;

public class cameraScript : MonoBehaviour {

	public Transform target; // set to the Player GameObject

	public Vector2 worldPosMin = new Vector2(-10f,-10f);
	public Vector2 worldPosMax = new Vector2(10f, 10f);

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (target != null)
		{
				Vector2 targetPos = target.transform.position;

				float x = Mathf.Clamp(targetPos.x, worldPosMin.x, worldPosMax.x);
				float y = Mathf.Clamp(targetPos.y, worldPosMin.y, worldPosMax.y);

				transform.position = new Vector3(target.position.x, y, transform.position.z);
		}
	}
}
