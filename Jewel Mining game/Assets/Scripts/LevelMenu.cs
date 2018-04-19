using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour {

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

}
