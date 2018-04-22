using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXaxis : MonoBehaviour {
	/*
	This script is for moving the fish on the x-axis
	and for the screen wrap functionality where the fish appear on the left end once they reach the right end
	also to add a sense of challenge they appear at a random y-axis on the left end
	*/

	Vector3 position;
	public int yRange = 3;
	bool free = true;	//determines whether the fish are caught or not , to stop them from moving when they are caught

	void Update () {

		Vector3 spawnLoc = new Vector3 (-12, Random.Range (-yRange, yRange), 0);

		position = transform.position;
		if (position.x > 11 && position.x < 12) {
			transform.SetPositionAndRotation(spawnLoc,transform.rotation);
		}

		if (free) {
			transform.Translate (0, 0, -0.03f);
		}

	}

	void OnTriggerEnter (Collider col)
	{
		free = false;
	}
}
