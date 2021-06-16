using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {

		Debug.Log ("collision");

		if (col.gameObject.CompareTag ("Enemy")) {
			Destroy (col.gameObject);
		}

		if (col.gameObject) {
			Destroy (gameObject);
		}
	}

}
