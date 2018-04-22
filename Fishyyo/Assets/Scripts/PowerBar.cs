using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour {

    Image powerBar;
    float maxPower = 100f;
    public static float power;
    bool isBreathing;


	void Start () {
        powerBar = GetComponent<Image>();
        power = 0;
	}
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
            isBreathing = true;
        if (Input.GetKeyUp(KeyCode.D))
            isBreathing = false;

        if (isBreathing)
        {
            power = power + Time.deltaTime * 50f;
           
        }
        else
        {
            power = 0;
        }

        powerBar.fillAmount = power / maxPower;
	}
}
