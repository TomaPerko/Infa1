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

    //Funkcija za primanje stete
    public void TakeDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;
        //Ako zivotni bodovi padnu ispod nule pokrece se funkcija za umiranje
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
    //Funkcija za umiranje
    void Die()
    {
        //Pokrece se 
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Unistava se gameObject
        Destroy(gameObject);
    }
    //Ova se funkcija pokrece kad se sudari s nekim drugim predmetom
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Provjerava je li vrijeme do sljedeceg napada jednako trenutnom vremenu
        if (Time.time >= VrijemeDoNapada)
        {
            //Daje stetu igracu
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
            //Postavlja se vrijeme do iduceg napada
            VrijemeDoNapada = Time.time + 1f / attackRate;
        }
    }
}
