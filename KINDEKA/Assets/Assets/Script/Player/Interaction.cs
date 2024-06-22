using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{

    [SerializeField] protected GameObject UIInteract;

    [SerializeField] public GameObject UIFindWord;

    public GameObject UINextScene;
    public GameObject WordMengembara;
    public GameObject WordBeruang;
    public GameObject WordMengendus;
    public GameObject WordMenyentuh;
    public GameObject WordBersahabat;

    public bool ifGrab = false;

    //public int boxCount = 0;

    private void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIInteract.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            UIInteract.SetActive(false);
        }
    }

    public void Grab(GameObject other)
    {
        if (UIInteract.activeSelf)
        {
            ifGrab = true;

            Destroy(gameObject);

            UIFindWord.SetActive(true);

            if (UINextScene.activeSelf)
            {
                SceneManager.LoadScene("Lvl2");
            }
        }
    }


}
