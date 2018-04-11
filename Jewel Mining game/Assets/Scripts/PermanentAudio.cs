using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermanentAudio : MonoBehaviour {

	void Awake () {
        GameObject[] audio = GameObject.FindGameObjectsWithTag("Audio");
        if (audio.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
	}
	
}
