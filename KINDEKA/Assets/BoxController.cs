using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxController : MonoBehaviour
{
    private int boxCount = 0;

    Interaction ifGrab;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Box"))
        {
            boxCount++;
            Debug.Log("Box++");

            if(boxCount >= 5)
            {
                SceneManager.LoadScene("Lvl2");
            }
        }
    }
}
