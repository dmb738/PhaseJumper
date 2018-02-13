using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase : MonoBehaviour {
	public AudioClip MusicClip;
	public AudioSource MusicSource;
	public enum PhaseState {Phase1, Phase2};
	public PhaseState phase;
	public GameObject player;
	SpriteRenderer playerSprite;

	private float timeStamp;
	public float cooldownSeconds = .5f;

	Collider2D collider;

	void Start(){
		collider = player.GetComponent<Collider2D> ();
		playerSprite = player.GetComponent<SpriteRenderer> ();
		player.layer = 8;
		playerSprite.color = Color.cyan;
		//MusicSource = GetComponent<AudioSource> ();
		MusicSource.clip = MusicClip;
	}
	
	// Update is called once per frame
	void Update () {
		if (phase == PhaseState.Phase1) {
			if (Input.GetKeyDown (KeyCode.Space) && timeStamp <= Time.time) {
				phase = PhaseState.Phase2;
				timeStamp = Time.time + cooldownSeconds;
				print ("Changed to Phase2");
				player.layer = 9;
				playerSprite.color = Color.red;
				//SoundManagerScript.PlaySound ("phaseChange");
				MusicSource.Play ();
			}

		}
		if (phase == PhaseState.Phase2) {
			if (Input.GetKeyDown (KeyCode.Space) && timeStamp <= Time.time) {
				phase = PhaseState.Phase1;
				timeStamp = Time.time + cooldownSeconds;
				// print ("Changed to Phase1");
				player.layer = 8;
				playerSprite.color = Color.cyan;
				MusicSource.Play ();
			}

		}
	}
}
