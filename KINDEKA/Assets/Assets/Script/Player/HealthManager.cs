using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int health;

    public int numOfHearts;

    //public float waitToHurt = 2f;

    public Image[] hearts;

    public Sprite fullHeart;

    public Sprite emptyHeart;


    private void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i<health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
            
        }
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            waitToHurt -= Time.deltaTime;
            if (waitToHurt <= 0)
            {
                health--;
                waitToHurt = 0.5f;
            }

            if(health < 0)
            {
                gameObject.SetActive(false);
            }
            Debug.Log("Player collided with NPC");
        }
    }*/

    public void HurtPlayer(int damageToGive)
    {
        health -= damageToGive;

        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
