using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSetting : MonoBehaviour {

    public SwapImage instance;
    public AudioMixer audioMixer;

	public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        if (volume == -60)
        {
            instance.swap();
        }
        else
        {
            instance.UnSwap();
        }
    }

}
