using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------- Audio Source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------------- Audio Clip -----------")]
    public AudioClip backsound;
    public AudioClip BoxCollecting;
    public AudioClip NPCFollowing;

    public void Start()
    {
        musicSource.clip = backsound;
        musicSource.Play();
    }

    public void ChangeMusic(AudioClip music)
    {
        if (musicSource.clip.name == music.name)
            return;

        musicSource.Stop();
        musicSource.clip = music;
        musicSource.Play();
    }


    public void PlaySFX(AudioClip sfx)
    {
        SFXSource.PlayOneShot(sfx);
    }


}
