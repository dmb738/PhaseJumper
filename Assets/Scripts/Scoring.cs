using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoring : MonoBehaviour {

    // Scoring Elements
    public GameObject player;
    public Text scoreText;
    float playerPosY;
    int score;

    // Use this for initialization
    void Start () {
        //Score value
        score = 0;

        //Text value
        SetScoreText();
    }
	
	// Update is called once per frame
	void Update () {
        // Seting playerPosY for tracking purposes
        playerPosY = player.transform.position.y;

        // Update score
        if (playerPosY > score)
        {
            score = (int)playerPosY;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        // Score based on strictly y value
        // scoreText.text = "Score: " + score.ToString();

        // Inflated score based on y value
        scoreText.text = "Score: " + score * 10;
    }
}
