using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public static int health;
    public static int maxHealth;

    void Start()
    {
        health = 100;
        maxHealth = 100;
    }

    public static void Takehit(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            SceneManager.LoadScene(0);
            Debug.Log("YOU DEAD");
        }

    }

    public static void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
