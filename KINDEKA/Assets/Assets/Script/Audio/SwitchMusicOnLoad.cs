using System.Collections;
using UnityEngine;

public class SwitchMusicOnLoad : MonoBehaviour
{
    public AudioClip newBgm;
    private AudioManager newAudioManager;

    public void Start()
    {
        newAudioManager = FindAnyObjectByType<AudioManager>();

        newAudioManager.PlaySFX(newBgm);
    }

}
