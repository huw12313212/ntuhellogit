using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	//private Transform myTransform;
	private Rigidbody2D myRigidBody2D;
	public ScoreManager scoreManager;

	// Use this for initialization
	void Start () {

		//myTransform = this.GetComponent<Transform> ();
		myRigidBody2D = this.GetComponent<Rigidbody2D>();

	}

	public float forceValue;

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			//myTransform.position += new Vector3 (0,speed * Time.deltaTime,0);
			myRigidBody2D.AddForce(new Vector2 (0,forceValue));

		}


		if (Input.GetKey (KeyCode.S)) {
			//myTransform.position += new Vector3 (0,speed * Time.deltaTime,0);
			myRigidBody2D.AddForce(new Vector2 (0,-forceValue));

		}

		if (Input.GetKey (KeyCode.A)) {
			//myTransform.position += new Vector3 (0,speed * Time.deltaTime,0);
			myRigidBody2D.AddForce(new Vector2 (-forceValue,0));

		}

		if (Input.GetKey (KeyCode.D)) {
			//myTransform.position += new Vector3 (0,speed * Time.deltaTime,0);
			myRigidBody2D.AddForce(new Vector2 (forceValue,0));

		}
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		other.gameObject.SetActive (false);
		scoreManager.AddScore (100);
	}
}
