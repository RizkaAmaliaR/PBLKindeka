using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxController : MonoBehaviour
{
    private int boxCount = 0;

    //Mengembara
    public GameObject UIInteractBoxMengembara;
    public GameObject UIFindWordMengembara;
    public GameObject BoxMengembara;

    //Beruang
    public GameObject UIInteractBoxBeruang;
    public GameObject UIFindWordBeruang;
    public GameObject BoxBeruang;

    //Mengendus
    public GameObject UIInteractBoxMengendus;
    public GameObject UIFindWordMengendus;
    public GameObject BoxMengendus;

    //Menyentuh
    public GameObject UIInteractBoxMenyentuh;
    public GameObject UIFindWordMenyentuh;
    public GameObject BoxMenyentuh;

    //Bersahabat
    public GameObject UIInteractBoxBersahabat;
    public GameObject UIFindWordBersahabat;
    public GameObject BoxBersahabat;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Box1"))
        {
            UIInteractBoxMengembara.SetActive(true);
        }
        if(other.gameObject.CompareTag("Box2"))
        {
            UIInteractBoxBeruang.SetActive(true);
        }
        if (other.gameObject.CompareTag("Box3"))
        {
            UIInteractBoxMengendus.SetActive(true);
        }
        if (other.gameObject.CompareTag("Box4"))
        {
            UIInteractBoxMenyentuh.SetActive(true);
        }
        if (other.gameObject.CompareTag("Box5"))
        {
            UIInteractBoxBersahabat.SetActive(true);
        }
    }
    public void Grab()
    {
        if (UIInteractBoxMengembara.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxMengembara);
            UIFindWordMengembara.SetActive(true);
            UIInteractBoxMengembara.SetActive(false);
        }

        if (UIInteractBoxBeruang.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxBeruang);
            UIFindWordBeruang.SetActive(true);
            UIInteractBoxBeruang.SetActive(false);
        }

        if (UIInteractBoxMengendus.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxMengendus);
            UIFindWordMengendus.SetActive(true);
            UIInteractBoxMengendus.SetActive(false);
        }

        if (UIInteractBoxMenyentuh.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxMenyentuh);
            UIFindWordMenyentuh.SetActive(true);
            UIInteractBoxMenyentuh.SetActive(false);
        }

        if (UIInteractBoxBersahabat.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxBersahabat);
            UIFindWordBersahabat.SetActive(true);
            UIInteractBoxBersahabat.SetActive(false);
        }
    }
    
    private void Update()
    {
        if(boxCount == 5)
        {
            SceneManager.LoadScene("Lvl2");
        }
        
    }
}
