using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float fltAttackRange = 0.6f;
    public LayerMask enemyLayers;

    void Update()
    {
    }

    void OnFire()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, fltAttackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("I hit" + enemy.name);
        }
    }
        void OnDrawGizmosSelected() 
    {
        if(attackPoint == null){return;}
        Gizmos.DrawWireSphere(attackPoint.position, fltAttackRange);
    }
}
