using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("------------- Audio Source -----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------------- Audio Clip -----------")]
    public AudioClip backsound;
    public AudioClip BoxCollecting;
    public AudioClip NPCFollowing;

    /*public void Start()
    {
        //DontDestroyOnLoad(gameObject);

        musicSource.clip = backsound;
        musicSource.Play();
        return;

        //fade in fade out
        //musicSource = GetComponent<AudioSource>();
        //musicSource.volume = 0f;
        //StartCoroutine(Fade(true, musicSource, 2f, 0.1f));
        //StartCoroutine(Fade(false, musicSource, 2f, 0f));
    }*/

    public void Awake()
    {
        musicSource.clip = backsound;
        musicSource.Play();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        /*musicSource.clip = backsound;
        musicSource.Play();
        return;*/
    }

    public void ChangeMusic(AudioClip music)
    {
        if (musicSource.clip.name == music.name)
        {
            return;
        }
        musicSource.Stop();
        //StartCoroutine(Fade(false, musicSource, 2f, 0f));
        musicSource.clip = music;
        //musicSource.volume = 0f;
        musicSource.Play();
        //StartCoroutine(Fade(true, musicSource, 2f, 0.1f));
    }


    public void PlaySFX(AudioClip sfx)
    {
        SFXSource.PlayOneShot(sfx);
    }

    /*public void StopBGM()
    {
        if(SceneManager.GetActiveScene().name == "DialoginDuniaWondelik")
        {
            musicSource.Pause();
        }
        if (SceneManager.GetActiveScene().name == "Lvl1")
        {
            musicSource.Pause();
        }
    }*/

    public void PauseMusic()
    {
        musicSource.Pause();
    }

    public void UnPauseMusic()
    {
        musicSource.UnPause();
        musicSource.Play();
    }

    void Update()
    {
        /*if(!musicSource.isPlaying)
        {
            musicSource.Play();
            StartCoroutine(Fade(true, musicSource, 2f, 0.1f));
            StartCoroutine(Fade(false, musicSource, 2f, 0f));
        }*/
    }

    /*public IEnumerator Fade(bool fadeIn, AudioSource musicSource, float duration, float targetVolume)
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
    }*/
}
