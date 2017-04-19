using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour {

	public GameObject BallObj;
	/// <summary>
	/// shot minimum speed
	/// </summary>
	public float minSpeed;
	/// <summary>
	/// shot maximum speed
	/// </summary>
	public float maxSpeed;


	// Use this for initialization
	void Start () {
		Shot ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Shot ();
		}
	}

	void Shot(){
		GameObject ball = (GameObject)Instantiate (BallObj, transform.position, Quaternion.identity);
		Rigidbody rigid = ball.GetComponent<Rigidbody> ();
		rigid.AddForce (Vector3.up * Random.Range(minSpeed,maxSpeed), ForceMode.Impulse);
	}
}
