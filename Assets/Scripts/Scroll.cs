using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    // Camera follows the player as they ascend
	public Transform target;
	public float scrollSpeed = .1f;
	
	void LateUpdate () {
		Vector2 offset = new Vector2 (0, target.position.y * scrollSpeed);

		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
