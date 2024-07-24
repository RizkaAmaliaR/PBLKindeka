using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBgm : MonoBehaviour
{
    private AudioManager newAudioManager;
    void Start()
    {
        newAudioManager = FindAnyObjectByType<AudioManager>();

        AudioManager.instance.GetComponent<AudioSource>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
