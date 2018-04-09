using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXaxis : MonoBehaviour {

	Vector3 position;
	Vector3 posX;
	Quaternion rot = new Quaternion (0, 0, 90, 0);

	// Update is called once per frame
	void Update () {
		posX.x = -12;

		position = transform.position;
		//print (position.x);
		if (position.x > 11 && position.x < 12) {
			transform.SetPositionAndRotation(posX,transform.rotation);
		}

		transform.Translate (0, 0, -0.03f);

	}
}
