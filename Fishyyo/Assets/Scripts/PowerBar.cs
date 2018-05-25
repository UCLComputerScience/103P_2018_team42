using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fizzyo;

public class PowerBar : MonoBehaviour {

    int score = 0;
    int breaths = 35;
    int breathCount = 0;

    private string PerfectBreathUID = "";

    Image powerBar;
    float maxPower = 70f;
    public static float power;
    bool isBreathing;
    public Hook hook;
    public Claw claw;

	void Start () {
        FizzyoFramework.Instance.Recogniser.BreathStarted += OnBreathStarted;
        FizzyoFramework.Instance.Recogniser.BreathComplete += OnBreathEnded;
        powerBar = GetComponent<Image>();
        power = 0;
	}

    void OnBreathStarted(object sender)
    {
        isBreathing = true;
        //Debug.Log("Breath started");
    }


    void OnBreathEnded(object sender, ExhalationCompleteEventArgs e)
    {
        isBreathing = false;
        breathCount++;

        //Debug.Log("Breath Quality : " + e.BreathQuality);

        if (e.BreathQuality >= 2)
        {
            score++;
        }

        if (e.BreathQuality >= 4)
        {
            FizzyoFramework.Instance.Achievements.UnlockAchievement(PerfectBreathUID);
        }

        if (breathCount > breaths)
        {
            FizzyoFramework.Instance.Achievements.PostScore(score);
            Application.Quit();
        }

    }

    void Update () {

        if (isBreathing)
        {
            power = power + Time.deltaTime * 50f;
            if (power >= maxPower)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    hook.LaunchClaw();
                }
               // print(power);
            }
        }
        else
        {
            power = 0;
        }

        powerBar.fillAmount = power / maxPower;
	}
}
