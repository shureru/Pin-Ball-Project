using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {

	/// <summary>
	/// バネの強さ(勢い)
	/// </summary>
	public float spring;
	/// <summary>
	/// スピード
	/// </summary>
	public float damper;
	/// <summary>
	/// 角度
	/// </summary>
	public float openAngle;
	/// <summary>
	/// 通常時の角度
	/// </summary>
	public float closeAngle;

	private HingeJoint hj;
	private Rigidbody rb;

	void Start () {
		hj = gameObject.GetComponent<HingeJoint>();
		hj.useSpring = true;
		rb = gameObject.GetComponent<Rigidbody>();
		rb.useGravity = false;
		closeFlipper ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow) && gameObject.name == "Arm_L" ||
			Input.GetKey (KeyCode.RightArrow) && gameObject.name == "Arm_R") {
			openFlipper ();
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow) && gameObject.name == "Arm_L" ||
			Input.GetKeyUp (KeyCode.RightArrow) && gameObject.name == "Arm_R") {
			closeFlipper();
		}

	}

	public void openFlipper(){
		JointSpring spr = hj.spring;
		spr.spring = spring;
		spr.damper = damper;
		spr.targetPosition = openAngle;
		hj.spring = spr;
	}

	public void closeFlipper(){
		JointSpring spr = hj.spring;
		spr.spring = spring;
		spr.damper = damper;
		spr.targetPosition = closeAngle;
		hj.spring = spr;
	}
}