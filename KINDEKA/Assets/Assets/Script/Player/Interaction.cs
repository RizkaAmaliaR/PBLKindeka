using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public int[] itemId;

    [SerializeField] protected GameObject UIInteract;

    [SerializeField] public GameObject UIFindWord;

    public bool ifGrab = false;

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
