using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    private int damageToGive = 1;

    public float waitToHurt;

    private HealthManager healtMan;

    public bool isTouching;

    private void Start()
    {
        healtMan = FindObjectOfType<HealthManager>();
    }

    private void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Hit");
            waitToHurt -= Time.deltaTime;
            if (waitToHurt <= 0)
            {
                healtMan.HurtPlayer(damageToGive);
                waitToHurt = 1f;
            }
        }
        
    }
}
