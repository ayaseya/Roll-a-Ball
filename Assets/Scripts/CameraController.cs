using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player; 	// 操作対象のボール

	private Vector3 offset;		// カメラからボールまでの距離、
								// カメラは常にボールからoffset分の距離を保つことになる

	void Start ()
	{
		// ボールの初期位置からoffsetを初期化する
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		// （移動後の）ボールの位置を元にカメラの位置を移動する
		transform.position = player.transform.position + offset;		
	}
}
