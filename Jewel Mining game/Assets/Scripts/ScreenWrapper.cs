using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour {
	float leftConstraint = Screen.width;
	float rightConstraint = Screen.width;
	float bottomConstraint = Screen.height;
	float topConstraint = Screen.height;
	float buffer = 1.0f;
	Camera cam;
	float distanceZ;


	// Use this for initialization
	void Start () {
		cam = Camera.main;
		distanceZ = Mathf.Abs (cam.transform.position.z + transform.position.z);
		leftConstraint = cam.ScreenToWorldPoint (new Vector3 (0.0f, 0.0f, distanceZ)).x;
		rightConstraint = cam.ScreenToWorldPoint (new Vector3 (Screen.width, 0.0f, distanceZ)).x;
		bottomConstraint = cam.ScreenToWorldPoint (new Vector3 (0.0f, 0.0f, distanceZ)).y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
