using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour {

	public void SelectEasy () {
        SceneManager.LoadScene(2);
    }

    public void SelectNormal()
    {
        SceneManager.LoadScene(3);
    }

    public void SelectHard()
    {
        SceneManager.LoadScene(4);
    }

}
