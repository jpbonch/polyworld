using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public GameObject bullet;
	public GameObject firingPoint;

	public float bulletSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			shootBullet ();
		}
	}

	void shootBullet(){
		GameObject tempBullet = Instantiate (bullet);
		tempBullet.transform.position = firingPoint.transform.position;

		tempBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
	}
}
