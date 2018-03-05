using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour {
	public AudioClip MusicClip;
	public AudioSource SoundSource;

	public GameObject player;
	// Player constantly moves upward a set amount upon hitting a platform


	void Start(){
		SoundSource.clip = MusicClip;
		player = GameObject.Find ("Player");
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f) {
			if (player.GetComponent<Player>().armor == 0) {
				SceneManager.LoadScene ("Test");
			} else {
				player.GetComponent<Player>().armor -= 1;
				player.GetComponent<Player>().armorText.text = "Armor: " + player.GetComponent<Player>().armor;
			}
			SoundSource.Play ();

		}
	}
}
