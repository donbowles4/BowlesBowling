using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
  public int intMaxHealth = 100;
  int intCurrentHealth;
    void Start()
    {
        intCurrentHealth = intMaxHealth;
    }

    public void TakeDamage(int damage)
    {
        intCurrentHealth -= damage;


        if(intCurrentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            this.enabled=false;
        }
    

}
