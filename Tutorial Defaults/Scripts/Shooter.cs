using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	GameObject player;
	public GameObject bullet;
	public float bulletSpeed;
	public GameObject firingPoint;


	public int shootCooldown;
	int shootCounter = 0;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void Update () {
		LookAtPlayer ();

		if (shootCounter < shootCooldown) {
			shootCounter++;
		} else {
			shootCounter = 0;
			Shoot ();
		}
	
	}

	void LookAtPlayer() {

		transform.LookAt (player.transform);

	}

	void Shoot() {

		GameObject tempBullet = Instantiate (bullet);
		tempBullet.transform.localPosition = firingPoint.transform.position;

		tempBullet.GetComponent<Rigidbody> ().velocity = transform.forward * bulletSpeed;
	}
}
