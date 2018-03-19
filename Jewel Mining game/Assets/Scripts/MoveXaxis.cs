using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXaxis : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, 0.01f);
	}
}
