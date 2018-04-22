using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour {
	/*
	 This script is for implementing the score system at the top left , where each fish is equal to 100 points
	 */ 
	public int score = 0;		// the actual score
	public int targetScore = 400;
	public Text scoreText;
	public GameObject youWon;
	public GameObject gameOver;


	void Awake () 
	{
		scoreText.text = ("Score: " + score + "/" + targetScore); // initializing scoreText
	}
		

	public void AddPoints(int pointScored)
	{
		score += pointScored;
		scoreText.text = ("Score: " + score + "/" + targetScore);
	}

	void CheckGameOver()
	{
		if (score >= targetScore)
		{
			Time.timeScale = 0;
			youWon.SetActive(true);
		}
		else
		{
			Time.timeScale = 0;
			gameOver.SetActive(true);
		}
	}

	void Update()
	{
		if (score >= targetScore)
		{
			Time.timeScale = 0;
			youWon.SetActive(true);
		}
	}


}