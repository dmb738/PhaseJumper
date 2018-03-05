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
    int scoreBuffer;

    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("ScoreBonus",0);

        //Score value
        score = 0;

        //Bonus score value, i.e. extra armor
        scoreBuffer = 0;

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
        }

        SetScoreText();
    }

    void SetScoreText()
    {
        // Score based on strictly y value
        // scoreText.text = "Score: " + score.ToString();

        // Inflated score based on y value
        if (PlayerPrefs.GetInt("ScoreBonus") == 50)
        {
            scoreBuffer += 50;
            PlayerPrefs.SetInt("ScoreBonus", 0);
        }
        scoreText.text = "Score: " + ((score * 10) + scoreBuffer);
    }
}
