using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class TriggerMusic : MonoBehaviour
{
    //public AudioClip newBgm;
    private AudioManager newAudioManager;
    public GameObject UIInfoWarning;

    AudioSource audioNPC;

    // Start is called before the first frame update
    void Start()
    {
        newAudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        audioNPC = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("masuk");
            AudioManager.instance.GetComponent<AudioSource>().Pause();
            audioNPC.Play();
            //newAudioManager.ChangeMusic(NPCFollow);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Keluar");
        audioNPC.Stop();
        AudioManager.instance.GetComponent<AudioSource>().UnPause();
    }

}
