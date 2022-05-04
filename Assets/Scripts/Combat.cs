using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] AudioClip swordSlash;
    public Animator animator;
    public Transform attackPoint;
    public float fltAttackRange = 0.6f;
    public LayerMask enemyLayers;
    public int intAttackDamage = 40;

    void Update()
    {
    }

    void OnFire()
    {
        animator.SetTrigger("Attack");
        AudioSource.PlayClipAtPoint(swordSlash,Camera.main.transform.position);
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, fltAttackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
           enemy.GetComponent<enemy>().TakeDamage(intAttackDamage);
        }
    }
        void OnDrawGizmosSelected() 
    {
        if(attackPoint == null){return;}
        Gizmos.DrawWireSphere(attackPoint.position, fltAttackRange);
    }
}
