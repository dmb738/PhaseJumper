using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour {
	public bool movingLeft;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= 6.5) {
			movingLeft = true;
		}
		if (transform.position.x <= -6.5) {
			movingLeft = false;
		}
		if (movingLeft) {
			transform.position += new Vector3 (-.1f, 0, 0);
		}
		if (!movingLeft) {
			transform.position += new Vector3 (.1f, 0, 0);
		}
	}
}
