using System.Collections;
using UnityEngine;

public class SwitchBgmBoxAnimation : MonoBehaviour
{
    [Header("------------- Audio Source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------------- Audio Clip -----------")]
    public AudioClip backsound;
    public AudioClip BoxCollecting;
    public AudioClip NPCFollowing;

    public GameObject BoxAnimation;


    public void Start()
    {
        musicSource.clip = backsound;
        musicSource.Play();

        musicSource = GetComponent<AudioSource>();
        musicSource.volume = 0f;
        StartCoroutine(Fade(true, musicSource, 2f, 0.1f));
        
    }

    public void ChangeMusic(AudioClip music)
    {
        if (musicSource.clip.name == music.name)
        {
            return;
        }
        musicSource.Stop();
        musicSource.clip = music;
        //musicSource.volume = 0f;
        musicSource.Play();
        //StartCoroutine(Fade(true, musicSource, 2f, 0.1f));
    }


    public void PlaySFX(AudioClip sfx)
    {
        SFXSource.PlayOneShot(sfx);
    }

    public void PauseMusic()
    {
        if(BoxAnimation.activeSelf)
        {
            musicSource.Pause();
        }
    }

    public IEnumerator Fade(bool fadeIn, AudioSource musicSource, float duration, float targetVolume)
    {
        if (!fadeIn)
        {
            double lengthOfSource = (double)musicSource.clip.samples / musicSource.clip.frequency;
            yield return new WaitForSecondsRealtime((float)(lengthOfSource - duration));
        }

        float time = 0f;
        float startVol = musicSource.volume;
        while (time < duration)
        {
            string fadeSituation = fadeIn ? "fadeIn" : "fadeOut";
            Debug.Log(fadeSituation);
            time += Time.deltaTime;
            musicSource.volume = Mathf.Lerp(startVol, targetVolume, time / duration);
            yield return null;
        }
        yield break;
    }

}
