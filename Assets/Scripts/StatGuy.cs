using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatGuy : MonoBehaviour {

	public GameObject player;

	void Start () {
		player = GameObject.Find ("Player");
	}
	
	void Update () {
		LookAtPlayer ();
	}

	void LookAtPlayer() {

		transform.LookAt (player.transform);

	}
}
