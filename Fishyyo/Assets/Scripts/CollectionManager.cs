using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour {

    public static CollectionManager instance;

    private bool[] fishUnlocked = new bool[6];
    
    void Start ()
    {
        for (int i = 0; i < fishUnlocked.Length; i++)
        {
            fishUnlocked[i] = false;
        }
    }

    private void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void unlock (int index)
    {
        fishUnlocked[index] = true;
    }

    public bool check (int index)
    {
        return fishUnlocked[index];
    }

}
