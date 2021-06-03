using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private int MaxHealth;
    public int CurrentHealth;
    public GameObject deathEffect;
    public int attackDamage = 10;
    void Start()
    {
        CurrentHealth = MaxHealth;
    }
    private void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
    }
}
