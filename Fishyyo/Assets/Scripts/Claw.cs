using UnityEngine;
using System.Collections;

public class Claw : MonoBehaviour {
	/*
	 This script is for generating the claw from the cube at the top that is used to catch the fish
	 Also, the collections system is implemented at the bottom , where different fish have different tags
	 this script integrates with the Hook script as they are all part of the fisher
	 */
	public Transform origin;	// where the hook will start
	public float speed = 4f;
	public Hook Hook;
	public ScoreManager scoreManager;

	private Vector3 target;
	private int fishValue = 100;
	private GameObject childObject;		//used to destroy the fish
	private LineRenderer lineRenderer;	//used to draw the fishing rope
	private bool hitFish;
	public bool retracting;
	Collider m_Collider;

	void Awake ()
	{
		lineRenderer = GetComponent<LineRenderer>();
		m_Collider = GetComponent<Collider>();
	}

	void Update(){

		float step = speed * Time.deltaTime;	// how much it moves each frame
		transform.position = Vector3.MoveTowards (transform.position, target, step);	//the position of the claw
		lineRenderer.SetPosition(0, origin.position);		//draw the line renderer from origin
		lineRenderer.SetPosition(1, transform.position);	//to the position of the claw

		if(!retracting) m_Collider.enabled = true;


		if (transform.position == origin.position && retracting)
		{
			Hook.CollectedObject();
			if (hitFish)
			{
				scoreManager.AddPoints(fishValue);
				hitFish = false;
			}
			Destroy(childObject);
			gameObject.SetActive(false);
			retracting = false;
		}
	}


	public void ClawTarget (Vector3 pos)
	{
		target = pos;
	}


	void OnTriggerEnter (Collider other)
	{
		retracting = true;
		target = origin.position;

        if (other.gameObject.CompareTag("Siganus"))
		{
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
            if (CollectionManager.instance != null)
            {
                CollectionManager.instance.unlock(0);
            }
		}

        if (other.gameObject.CompareTag("Mandarin"))
        {
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
            if (CollectionManager.instance != null)
            {
                CollectionManager.instance.unlock(1);
            }
        }

        if (other.gameObject.CompareTag("Yellowtang"))
        {
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
            if (CollectionManager.instance != null)
            {
                CollectionManager.instance.unlock(2);
            }
        }
        print(Input.GetJoystickNames());
        if (other.gameObject.CompareTag("Powderbluetang"))
        {
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
            if (CollectionManager.instance != null)
            {
                CollectionManager.instance.unlock(3);
            }
        }

        if (other.gameObject.CompareTag("Crab"))
        {
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
            if (CollectionManager.instance != null)
            {
                CollectionManager.instance.unlock(4);
            }
        }

        if (other.gameObject.CompareTag("Koi"))
        {
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
            if (CollectionManager.instance != null)
            {
                CollectionManager.instance.unlock(5);
            }
        }
       
    }
}




