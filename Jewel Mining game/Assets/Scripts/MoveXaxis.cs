using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXaxis : MonoBehaviour {

	Vector3 position;
	Quaternion rot = new Quaternion (0, 0, 0, 0);
	public int yRange = 3;
	bool free = true;


	// Update is called once per frame
	void Update () {

		Vector3 spawnLoc = new Vector3 (-12, Random.Range (-yRange, yRange), 0);

		position = transform.position;
		//print (position.x);
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
