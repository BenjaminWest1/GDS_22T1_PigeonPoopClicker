using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = SoundManager.volume;
    }
}
