using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider volumeSlider;
    public static float volume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = volume;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        volume = volumeSlider.value;
    }
}
