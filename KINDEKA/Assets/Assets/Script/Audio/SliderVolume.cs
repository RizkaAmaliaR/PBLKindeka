using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderVolume : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetVolume()
    {
        mixer.SetFloat("volume", volumeSlider.value);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
