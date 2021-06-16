using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	Rigidbody rb;
	public float moveSpeed;
	public float jumpPower;
	public float height = 5;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		movePlayer ();
	}

	void movePlayer(){
		Vector3 velocity = new Vector3 (0, rb.velocity.y, 0);

		if (Input.GetKey (KeyCode.W)) {
			velocity += new Vector3 (transform.forward.x, 0, transform.forward.z) * moveSpeed;
		}
		if (Input.GetKey (KeyCode.A)) {
			velocity += new Vector3 (transform.right.x, 0, transform.right.z) * -moveSpeed;
		}
		if (Input.GetKey (KeyCode.S)) {
			velocity += new Vector3 (transform.forward.x, 0, transform.forward.z) * -moveSpeed;
		}
		if (Input.GetKey (KeyCode.D)) {
			velocity += new Vector3 (transform.right.x, 0, transform.right.z) * moveSpeed;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			jump ();
		}

		rb.velocity = velocity;
	}

	void jump()
	{
		bool grounded = Physics.Raycast (transform.position, Vector3.down, height);
		if (grounded == true) {
			rb.AddForce (Vector3.up * jumpPower);
		}
	}

}
