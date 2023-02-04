using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public int damage = 25;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        {

            if (collision.gameObject.tag == "Player")
            {
                Health.Takehit(damage);
                Debug.Log("-25");
            }
        }
    }
}