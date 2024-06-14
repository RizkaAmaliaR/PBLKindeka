using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public float waitToHurt = 2f;
    public int Dmg; // damage

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        HealthManager curHealth = collision.gameObject.GetComponent<HealthManager>();
        if (curHealth != null)
        {
            //curHealth.TakeDamage(Dmg);
        }
    }
}
