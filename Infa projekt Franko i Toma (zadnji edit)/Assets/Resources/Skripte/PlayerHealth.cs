using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

	public int health = 100;

	public GameObject deathEffect;
	public HealthBar_Script healthbar;

    private void Start()
    {
		healthbar.SetMaxhealth(health);
    }
	//Funkcija za primanje stete
    public void TakeDamage(int damage)
	{
		health -= damage;
		healthbar.SetHealth(health);

		if (health <= 0)
		{
			Die();
		}
	}
	//Funkcija za umiranje
	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}