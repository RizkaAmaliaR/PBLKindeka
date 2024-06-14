using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int curHealth;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            // Reduce player health
            curHealth--;
            Debug.Log("Hit");

        }
    }
}
