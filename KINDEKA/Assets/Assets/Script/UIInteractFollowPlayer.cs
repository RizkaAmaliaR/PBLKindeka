using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteractFollowPlayer : MonoBehaviour
{
    public GameObject canvas; // Reference to your UI canvas

    private Transform playerTransform;

    void Start()
    {
        // Assuming you have a Player object with a "Player" tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Set the canvas rotation to match the player's rotation
        canvas.transform.rotation = playerTransform.rotation;
    }

    // Other methods (OnTriggerEnter, etc.) can remain unchanged
}
