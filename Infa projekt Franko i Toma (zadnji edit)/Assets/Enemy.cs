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
    public float VrijemeDoNapada;
    public float attackRate = 1;
    void Start()
    {
        CurrentHealth = MaxHealth;
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
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Time.time >= VrijemeDoNapada)
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
            VrijemeDoNapada = Time.time + 1f / attackRate;
        }
    }
}
