using UnityEngine;
using System.Collections;

public class Robot_blast : MonoBehaviour {

	// Use this for initialization
	void Start () {
		foreach (Transform t in transform) {
			t.gameObject.rigidbody2D.AddForce(new Vector2(Random.Range(-600f,600f),Random.Range(200f,800f)));
			t.gameObject.rigidbody2D.AddTorque(Random.Range(-40f,40f));
		}
	}
}
