using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour {

	/*
	 this script is for selecting different difficulties and scenes
	 */ 
	public void SelectEasy () {
        SceneManager.LoadScene("Day");
    }

    public void SelectNormal()
    {
        SceneManager.LoadScene("Sunset");
    }

    public void SelectHard()
    {
        SceneManager.LoadScene("Night");
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
