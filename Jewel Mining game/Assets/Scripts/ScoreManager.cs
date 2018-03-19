using UnityEngine;
using System.Collections;
using UnityEngine.UI; // unity library for UI

public class ScoreManager : MonoBehaviour {

	public int score = 0;		// the actual score
	public int targetScore = 400;
	public Text scoreText;
	public GameObject youWon;
	public GameObject gameOver;


	void Awake () 
	{
		scoreText.text = ("Score: " + score + "/" + targetScore); // initializing scoreText

		//InvokeRepeating("Clock", 0, clockSpeed);// InvokeRepeating allows us to repeatedly call a function , the 2nd parameter is the delay before first call
		//3rd parameter is the time between each call
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