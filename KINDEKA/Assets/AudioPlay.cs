using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    AudioManager audioManager;
    public AudioClip backsound;

    public AudioSource audioSource;
    public AudioClip NPCFollow;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioManager.ChangeMusic(backsound);

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = NPCFollow;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
