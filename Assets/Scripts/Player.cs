using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
	public AudioClip armorPickup;
	public AudioClip enemyHit;
	public AudioSource SoundSource;

	SpriteRenderer playerSprite;

	public float movement = 0f;
	public float movementSpeed = 10f;

	public GameObject leftBounds;
	public GameObject rightBounds;

	public float offset = 1.001f;
    // Armor System starts with player having 1 armor
    public int armor = 0;
    // Indicates how much armor the player currently has
    public Text armorText;
    public Text gameOverText;

	Rigidbody2D rb;
    
	void Start () {
		playerSprite = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
		leftBounds = GameObject.Find ("LeftBounds");
		rightBounds = GameObject.Find ("RightBounds");
        SetArmorText();
    }
	
    // Moves player to left side of the screen if they pass the right side and vice versa
	void Update () {
		movement = Input.GetAxis ("Horizontal")*movementSpeed;

		Vector3 teleport = new Vector3 ((transform.position.x * (-1)) * offset, transform.position.y, transform.position.z);

		if (transform.position.x >= rightBounds.transform.position.x) {

			transform.position = teleport;
		}
		if (transform.position.x <= leftBounds.transform.position.x) {

			transform.position = teleport;
		}
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        // Adds one armor to the player, max of three
        if (other.gameObject.CompareTag("Armor") && armor < 3)
        {
            other.gameObject.SetActive(false);
            armor += 1;
            SetArmorText();
			SoundSource.clip = armorPickup;
			SoundSource.Play ();
        }
        // If you hit an enemy and you don't have armor to tank the hit, you die
        else if (other.gameObject.CompareTag("Enemy"))
        {
            if (armor == 0)
            {
                GameOver();
            }
            else
            {
                other.gameObject.SetActive(false);
                armor -= 1;
                SetArmorText();
            }
			SoundSource.clip = enemyHit;
			SoundSource.Play ();
        }
    }

    void SetArmorText()
    {
        armorText.text = "Armor: " + armor;
    }
    // Restarts from the beginning upon death
    void GameOver()
    {
        SceneManager.LoadScene("Test");
    }

}