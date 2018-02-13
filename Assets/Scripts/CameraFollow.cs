using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {

	public Transform target;

		void LateUpdate () {
		if (target.position.y > transform.position.y) {

			transform.position = new Vector3 (transform.position.x, target.position.y , transform.position.z);
		}
		 
	}

    // Hitting the bottom of the screen results in death
	public void OnCollisionEnter2D(Collision2D collision) {
		SceneManager.LoadScene ("Test");
	}
}
