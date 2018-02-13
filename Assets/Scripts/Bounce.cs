using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {
	public AudioClip MusicClip;
	public AudioSource SoundSource;

    // Player constantly moves upward a set amount upon hitting a platform
	public float jumpForce = 12f;

	void Start(){
		SoundSource.clip = MusicClip;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f) {

			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D> ();
			if (rb != null) {
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
				SoundSource.Play ();
			}
		}
	}
}
