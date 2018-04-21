using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectionScene : MonoBehaviour {

    public Image[] fishes = new Image[6];
    private bool[] collected = new bool[6];

    private void Start ()
    {
        for (int i = 0; i < fishes.Length; i++)
        {
            collected[i] = CollectionManager.instance.check(i);
            if (collected[i] == false)
            {
                fishes[i].color = Color.black;
            }
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(1);
    }


}
