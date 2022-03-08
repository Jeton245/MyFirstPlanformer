using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth;
    int correnthealth;
    public int pointGod = 0 ;
    void Start()
    {
        correnthealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        correnthealth -= damage;

        animator.SetTrigger("Hurt");

        if (correnthealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Enemy Dead");
        animator.SetBool("IsDead",true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        Destroy(gameObject, 1.7f);
        pointGod += 1;
    }

    
}
