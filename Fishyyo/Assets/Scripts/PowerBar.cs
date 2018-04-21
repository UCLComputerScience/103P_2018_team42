using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour {

    Image powerBar;
    float maxPower = 100f;
    public static float power;
    bool isBreathing;

	// Use this for initialization
	void Start () {
        powerBar = GetComponent<Image>();
        power = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
            isBreathing = true;
        if (Input.GetKeyUp(KeyCode.D))
            isBreathing = false;

        if (isBreathing)
        {
            power = power + Time.deltaTime * 50f;
            //Debug.Log(power);
        }
        else
        {
            power = 0;
        }

        powerBar.fillAmount = power / maxPower;
	}
}
