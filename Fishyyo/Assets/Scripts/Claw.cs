using UnityEngine;
using System.Collections;

public class Claw : MonoBehaviour {

	public Transform origin;
	public float speed = 4f;
	public Hook Hook;
	public ScoreManager scoreManager;

	private Vector3 target;
	private int fishValue = 100;
	private GameObject childObject;
	private LineRenderer lineRenderer;
	private bool hitFish;
	private bool retracting;
	Collider m_Collider;

	void Awake ()
	{
		lineRenderer = GetComponent<LineRenderer>();
		m_Collider = GetComponent<Collider>();
	}

	void Update(){

		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target, step);
		lineRenderer.SetPosition(0, origin.position);
		lineRenderer.SetPosition(1, transform.position);

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
			//CollectionManager.instance.unlock(0);
		}

        if (other.gameObject.CompareTag("Mandarin"))
        {
            CollectionManager.instance.unlock(1);
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
        }

        if (other.gameObject.CompareTag("Yellowtang"))
        {
            CollectionManager.instance.unlock(2);
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
        }

        if (other.gameObject.CompareTag("Powderbluetang"))
        {
            //CollectionManager.instance.unlock(3);
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
        }

        if (other.gameObject.CompareTag("Crab"))
        {
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
			CollectionManager.instance.unlock(4);
        }

        if (other.gameObject.CompareTag("Koi"))
        {
            CollectionManager.instance.unlock(5);
			hitFish = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
			m_Collider.enabled = false;
        }
       
    }
}




