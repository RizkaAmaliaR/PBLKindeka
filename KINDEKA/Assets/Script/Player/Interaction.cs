using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{

    [SerializeField] protected GameObject UIInteract;

    [SerializeField] public GameObject UIFindWord;

    public GameObject scriptPointPlace;

    public bool ifGrab;

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

    public void Grab()
    {
        if (UIInteract.activeSelf)
        {
            ifGrab = true;

            Destroy(gameObject);

            UIFindWord.SetActive(true);
        }
    }


}
