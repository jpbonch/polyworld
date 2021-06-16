using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiostay : MonoBehaviour {

	public AudioSource audio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	static bool AudioBegin = false; 
	void Awake()
	{
		if (!AudioBegin) {
			audio.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
}
