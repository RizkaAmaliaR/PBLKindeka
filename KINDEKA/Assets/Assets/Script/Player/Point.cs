using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Point : MonoBehaviour
{

    public static int point = 0;

    [SerializeField] private Text PointText;

    public Interaction interactScript;
    private void Start()
    {
        interactScript = GameObject.FindAnyObjectByType<Interaction>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            
        }

    }
}
