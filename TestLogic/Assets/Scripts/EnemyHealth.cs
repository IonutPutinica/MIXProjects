using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 50.0f;
    [SerializeField]
    private GameObject enemy;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0.0f)
        {
            EnemyDeath();
        }
    }

    private void EnemyDeath()
    {
        Debug.Log("ENEMY HAS NO MORE HEALTH!");
        enemy.SetActive(false);
    }
}
