using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject destructionPoint;

	void Start () {
		destructionPoint = GameObject.Find ("DestructionPoint");
	}
	
	void Update () {

        // Destroys off screen assets
		if (transform.position.y < destructionPoint.transform.position.y)
		{
			Destroy (gameObject);
		}
	}
}
