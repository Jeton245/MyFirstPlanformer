using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour 
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public int Damage = 20;
    public float attackRange = 0.5f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Attack();
        }
    }
    
    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(Damage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
