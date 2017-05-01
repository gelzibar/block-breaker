using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log ("Trigger");
		GameObject.Find ("LevelManager").GetComponent<LevelManager> ().LoadLevel ("Win");
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log ("Collision");
	}
}
