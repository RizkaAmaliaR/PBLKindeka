using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int health;

    public int numOfHearts;

    public Image[] hearts;

    public Sprite fullHeart;

    public Sprite emptyHeart;

    public GameObject UIKalah;

    public GameObject NPC;


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

    public void HurtPlayer(int damageToGive)
    {
        health -= damageToGive;

        if(health < 0)
        {
            UIKalah.SetActive(true);
            NPC.SetActive(false);
        }
    }
}
