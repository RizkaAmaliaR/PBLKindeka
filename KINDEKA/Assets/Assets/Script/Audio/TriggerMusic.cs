using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class TriggerMusic : MonoBehaviour
{
    public AudioClip NPCFollow;
    public AudioClip newBgm;
    private SwitchBgmBoxAnimation newAudioManager;

    // Start is called before the first frame update
    void Start()
    {
        newAudioManager = FindAnyObjectByType<SwitchBgmBoxAnimation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("masuk");
            newAudioManager.ChangeMusic(NPCFollow);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Keluar");
        newAudioManager.ChangeMusic(newBgm);
    }

}
