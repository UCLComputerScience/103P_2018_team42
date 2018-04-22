using UnityEngine;
using System.Collections;

public class SpawnFish : MonoBehaviour {
	
	/*
	 this script is for spawning fish (that were specified in the Scoremanager) at random x and y values (in certain ranges)
	 this adds some randomness to the game
	 */ 

	public int xRange = 10;
	public int yRange = 3;
	public int numObjects = 16;
	Quaternion sp = new Quaternion(0,-90,0,90);
	public GameObject[] objects;

	void Start () 
	{
		Spawn ();
	}

	void Spawn()
	{
		for (int i = 0; i <= numObjects; i++)
		{
			Vector3 spawnLoc = new Vector3 (Random.Range (-xRange, xRange), Random.Range (-yRange, yRange), 0);//random x and y location , z =0
			int objectPick = Random.Range (0, objects.Length); //random object index from the object list 
			Instantiate(objects[objectPick], spawnLoc , sp); // instantiate this object
		}
	}
}