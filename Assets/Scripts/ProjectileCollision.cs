using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Enemy")) {
			other.gameObject.SetActive (false);
		}
	}
}
