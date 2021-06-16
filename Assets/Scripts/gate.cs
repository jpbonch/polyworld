using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gate : MonoBehaviour {

	public GameObject[] enemies;
	public string nextScene;
	public 

	void Start () {
		
	}
	

	void Update () {
		
	}
		

	void  OnCollisionEnter(Collision col) {

		if (col.gameObject.CompareTag ("Player")) {
			// check enemies
			bool finish = checkEnemies();

			if (finish == true) {
				// switch to next level
				SceneManager.LoadScene(nextScene);
			} else {
				Debug.Log ("Still Enemies Alive");
		}

	}
	
}


	bool checkEnemies (){

		foreach (GameObject enemy in enemies) {
			if (enemy != null) {
				return(false);
			}
		}

		return(true);
	}
}