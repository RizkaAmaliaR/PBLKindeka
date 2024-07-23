using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBacksound : MonoBehaviour
{
    AudioManager audioManager;
    public AudioClip musicBacksound;

    //public AudioSource audioSource;
    //public AudioClip backsound;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager.ChangeMusic(musicBacksound);

        //audioSource = GetComponent<AudioSource>();
        //audioSource.clip = backsound;
        //audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
