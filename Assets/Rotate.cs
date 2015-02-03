using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float speed = 60f;
	float angle = 0f;

	// Update is called once per frame
	void Update () {

		angle = Mathf.Repeat (angle + Time.deltaTime * speed, 360f);
		transform.rotation = Quaternion.Euler (0f, angle, 0f);
	}
}
