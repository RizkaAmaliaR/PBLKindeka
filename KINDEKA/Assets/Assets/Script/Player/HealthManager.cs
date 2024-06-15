using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int curHealth;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("NPC"))
        {
            // Reduce player health
            curHealth--;
            Debug.Log("Hit");

        }
    }
}
