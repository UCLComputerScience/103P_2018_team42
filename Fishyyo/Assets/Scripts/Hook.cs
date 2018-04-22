using UnityEngine;
using System.Collections;
//use Fizzyo namespace
using Fizzyo;

public class Hook : MonoBehaviour {
	/*
	 This is part of the fisher that is used for emitting the black line (line Renderer) , also most the fizzyo device is integrated here
	 */
	public GameObject claw;		
	public bool isShooting;
	public Animator minerAnimator;
	public Claw clawScript;

	int score = 0;
	int breaths = 35;
	int breathCount = 0;

	private string PerfectBreathUID = "";

	void Start(){
		FizzyoFramework.Instance.Recogniser.BreathStarted += OnBreathStarted;
		FizzyoFramework.Instance.Recogniser.BreathComplete += OnBreathEnded;
	}

	void Update(){
		//get exhale pressure between -1 and 1
		float pressure = FizzyoFramework.Instance.Device.Pressure();
		//Debug.Log("Exhale pressure: " + pressure);

		if (Input.GetButtonDown("Horizontal") && !isShooting)
		{
			LaunchClaw();
		}

	}

	void OnBreathStarted(object sender)
	{
		//Debug.Log("Breath started");
	}


	void OnBreathEnded(object sender, ExhalationCompleteEventArgs e)
	{
		breathCount++;

		//Debug.Log("Breath Quality : " + e.BreathQuality);

		if(e.BreathQuality >= 2){
			score++;
		}

		if(e.BreathQuality >= 4){
			FizzyoFramework.Instance.Achievements.UnlockAchievement(PerfectBreathUID);
		}

		if(breathCount > breaths){
			FizzyoFramework.Instance.Achievements.PostScore(score);
			Application.Quit();
		}

	}


	void LaunchClaw()
	{
		isShooting = true;
		minerAnimator.speed = 0;
		RaycastHit hit;
		Vector3 down = transform.TransformDirection(Vector3.down);

		if(Physics.Raycast(transform.position, down, out hit, 80))
		{
			claw.SetActive(true);
			clawScript.ClawTarget(hit.point);
		}
	}

	public void CollectedObject()
	{
		isShooting = false;
		minerAnimator.speed = 1;
	}
}