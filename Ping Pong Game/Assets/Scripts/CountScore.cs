﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour {

	public Text scoreText;
	[SerializeField]
	private int scoreValue;
	[SerializeField]
	private int winScore;
	[SerializeField]
    private Text playerWin;


	// Use this for initialization
	void Start () {
		//Set the score to zero
		scoreValue = 0;
        winScore = 10;
		UpdateScoreText ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Alter the score
	public void UpdateScoreValue (int scoreUpdate){
		//Update the score
		scoreValue += scoreUpdate;

		//Update the text of the score in the UI
		UpdateScoreText ();

        //Check if player has won
        
		if (scoreValue >= winScore)
        {
            //playerWin.text = "You win: " + playerTupe;
            SceneManager.LoadScene("GameOver");
		}
		
    }

    //Update the score in the game
    void UpdateScoreText ()
    {
		scoreText.text = "Score: " + scoreValue;
	}

	//Reset score to zero
	void ResetScore ()
    {
		scoreValue = 0;
		UpdateScoreText();
	}


}
