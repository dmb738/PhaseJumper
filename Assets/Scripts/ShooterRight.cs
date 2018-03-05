using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterRight : MonoBehaviour {

	public GameObject projectile;
	private float timeStamp;
	public float cooldownSeconds = 5f;

	// Use this for initialization
	void Start () {
		//projectile = GameObject.Find ("projectile");
		timeStamp = Time.time;
	}

	// Update is called once per frame
	void Update () {
		if (timeStamp <= Time.time) {
			fire ();
			timeStamp += cooldownSeconds;
		}
	}
	void fire(){
		var bullet = (GameObject)Instantiate (projectile, transform.position, transform.rotation);
		bullet.GetComponent<Rigidbody2D> ().velocity = bullet.transform.up * 6;
		Destroy (bullet, 2.0f);
	}
}
