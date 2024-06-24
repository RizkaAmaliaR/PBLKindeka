using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxController : MonoBehaviour
{
    private int boxCount = 0;

    public GameObject MissionCompleted;

    //Mengembara
    public GameObject UIInteractBoxMengembara;
    public GameObject UIFindWordMengembara;
    public GameObject BoxMengembara;
    public GameObject BoxMarkerMengembara;

    //Beruang
    public GameObject UIInteractBoxBeruang;
    public GameObject UIFindWordBeruang;
    public GameObject BoxBeruang;
    public GameObject BoxMarkerBeruang;

    //Mengendus
    public GameObject UIInteractBoxMengendus;
    public GameObject UIFindWordMengendus;
    public GameObject BoxMengendus;
    public GameObject BoxMarkerMengendus;

    //Menyentuh
    public GameObject UIInteractBoxMenyentuh;
    public GameObject UIFindWordMenyentuh;
    public GameObject BoxMenyentuh;
    public GameObject BoxMarkerMenyentuh;

    //Bersahabat
    public GameObject UIInteractBoxBersahabat;
    public GameObject UIFindWordBersahabat;
    public GameObject BoxBersahabat;
    public GameObject BoxMarkerBersahabat;

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

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Box1"))
        {
            UIInteractBoxMengembara.SetActive(false);
        }
        if (other.gameObject.CompareTag("Box2"))
        {
            UIInteractBoxBeruang.SetActive(false);
        }
        if (other.gameObject.CompareTag("Box3"))
        {
            UIInteractBoxMengendus.SetActive(false);
        }
        if (other.gameObject.CompareTag("Box4"))
        {
            UIInteractBoxMenyentuh.SetActive(false);
        }
        if (other.gameObject.CompareTag("Box5"))
        {
            UIInteractBoxBersahabat.SetActive(false);
        }
    }

    public void Grab()
    {
        if (UIInteractBoxMengembara.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxMengembara);
            Destroy(BoxMarkerMengembara);
            UIFindWordMengembara.SetActive(true);
            UIInteractBoxMengembara.SetActive(false);
        }

        if (UIInteractBoxBeruang.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxBeruang);
            Destroy(BoxMarkerBeruang);
            UIFindWordBeruang.SetActive(true);
            UIInteractBoxBeruang.SetActive(false);
        }

        if (UIInteractBoxMengendus.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxMengendus);
            Destroy(BoxMarkerMengendus);
            UIFindWordMengendus.SetActive(true);
            UIInteractBoxMengendus.SetActive(false);
        }

        if (UIInteractBoxMenyentuh.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxMenyentuh);
            Destroy(BoxMarkerMenyentuh);
            UIFindWordMenyentuh.SetActive(true);
            UIInteractBoxMenyentuh.SetActive(false);
        }

        if (UIInteractBoxBersahabat.activeSelf)
        {
            boxCount++;
            Debug.Log("Box =" + boxCount);
            Destroy(BoxBersahabat);
            Destroy(BoxMarkerBersahabat);
            UIFindWordBersahabat.SetActive(true);
            UIInteractBoxBersahabat.SetActive(false);
        }
    }
    
    private void Update()
    {
        if(boxCount == 5)
        {
            MissionCompleted.SetActive(true);
        }
        
    }
}
