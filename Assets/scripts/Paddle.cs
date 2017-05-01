using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


	private float mousePosInBlocks;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SetMousePosInBlocks (Input.mousePosition.x / Screen.width * 16 - 8);
		Debug.Log (mousePosInBlocks);

		Vector3 paddlePos = new Vector3(mousePosInBlocks, this.transform.position.y, this.transform.position.z);

		paddlePos.x = Mathf.Clamp (paddlePos.x, -7.5f, 7.5f);
		this.transform.position = paddlePos;
		
	}

	void SetMousePosInBlocks(float pos) {
		mousePosInBlocks = pos;
	}
}
