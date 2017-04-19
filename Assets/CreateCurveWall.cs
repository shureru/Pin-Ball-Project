using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCurveWall : MonoBehaviour {

	/// <summary>
	/// いっぱい置く円柱のオブジェクト
	/// </summary>
	public GameObject CylinderObj;

	/// <summary>
	/// 楕円の中心座標
	/// </summary>
	public float centerX;

	/// <summary>
	/// 楕円の中心座標
	/// </summary>
	public float centerY;

	/// <summary>
	/// x軸方向の半径
	/// </summary>
	public float rx;

	/// <summary>
	/// y軸方向の半径
	/// </summary>
	public float ry;

	/// <summary>
	/// 円柱を置く間隔
	/// </summary>
	public float interval;



	// Use this for initialization
	void Start () {

		for (float x = -rx; x <= rx; x += interval) {
			float y = ry * Mathf.Sqrt (1 - Mathf.Pow (x, 2.0f) / Mathf.Pow (rx, 2.0f));
			Instantiate (CylinderObj, new Vector3 (x, 0, y), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
