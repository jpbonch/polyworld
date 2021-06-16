using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemybullet : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.CompareTag ("Player")) {

			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		}

		Destroy (transform.gameObject);
	}

}
