using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenWrap : MonoBehaviour {

	public GameObject obj;
	public Transform tpLoc;


	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.CompareTag("Jewel")) {
			print ("dd");
			obj.transform.position = tpLoc.transform.position;
		}
	}
}
