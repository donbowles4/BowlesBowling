using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int intMaxHealth = 100;
    int intCurrentHealth;
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
            GameManager.intPinsKnocked += 1;
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
