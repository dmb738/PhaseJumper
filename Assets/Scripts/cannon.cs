using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {

	public GameObject projectile;
	public GameObject bulletSpawn;
	public GameObject reticle;
	public float rotationSpeed = 2f;
	//public Transform cannonRot = transform.rotation;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate (Vector3.forward * -rotationSpeed);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate (Vector3.forward * rotationSpeed);
		}
		if (Input.GetKeyDown (KeyCode.Return)) {
			fire ();
		}
	}
	void fire(){
		var bullet = (GameObject)Instantiate (projectile, bulletSpawn.transform.position, Quaternion.identity);
		//Vector3 movement = new Vector3 (reticle.transform.position.x, reticle.transform.position.y, reticle.transform.position.z);
		bullet.GetComponent<Rigidbody2D> ().velocity = (transform.rotation * Vector3.right) * 10;
		//bullet.transform.Translate(movement * Time.deltaTime * 4);
		Destroy (bullet, 2.0f);
	}
}
