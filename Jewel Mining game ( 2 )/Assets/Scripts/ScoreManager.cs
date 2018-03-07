using UnityEngine;
using System.Collections;
using UnityEngine.UI; // unity library for UI

public class ScoreManager : MonoBehaviour {

	public int score = 0;		// the actual score
	public int targetScore = 400;
	public Text scoreText;
	public Text timeText;
	public int timePerLevel = 30; // 30 secs to complete the level
	public GameObject youWon;
	public GameObject gameOver;


	private float clockSpeed = 1f;


	void Awake () 
	{
		scoreText.text = ("Score: " + score + "/" + targetScore); // initializing scoreText

		InvokeRepeating("Clock", 0, clockSpeed);// InvokeRepeating allows us to repeatedly call a function , the 2nd parameter is the delay before first call
		//3rd parameter is the time between each call
	}

	void Clock()
	{
		timePerLevel--;
		timeText.text = ("Time: " + timePerLevel);
		if (timePerLevel == 0)
		{
			CheckGameOver();
		}
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

}