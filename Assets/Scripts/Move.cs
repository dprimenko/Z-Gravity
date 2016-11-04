using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Update is called once per frame
	void FixedUpdate () {
		//GetComponent<Rigidbody2D> ().AddForce ((Vector2.right * 3f));
		GetComponent<Rigidbody2D> ().AddForce (new Vector2((Input.acceleration.x * 5f), 0));

		foreach (Touch touch in Input.touches) {
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up, ForceMode2D.Impulse );
		}
	}
}
