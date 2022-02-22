using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameSound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject cameraAudio;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = cameraAudio.GetComponent<AudioSource>();
        AudioListener.volume = SoundManager.volume;
        audioSource.volume = 0.25f;
        audioSource.Play();
    }

    public void BeginGame()
    {
        audioSource.volume = 1;
        audioSource.time += 3f;
    }

    public void EndOfGame()
    {
        audioSource.volume = 0.5f;
    }
}
