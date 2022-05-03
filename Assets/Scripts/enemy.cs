using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
  public int intMaxHealth = 100;
  int intCurrentHealth;
  public int intPinsKnocked = 0;
  GameObject bowlingPin;
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
            GetComponent<GameManager>().PinCount();
        }
    }

    public void Die()
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(bowlingPin);
            this.enabled=false;
        }
    

}
