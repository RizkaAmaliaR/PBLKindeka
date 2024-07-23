using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class TriggerMusic : MonoBehaviour
{
    public AudioClip None;

    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("masuk");
            audioManager.ChangeMusic(None);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Keluar");
        audioManager.ChangeMusic(audioManager.backsound);
    }

}
