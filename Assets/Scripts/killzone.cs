﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {

		if(col.CompareTag("Player")) {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		}

	}

}
