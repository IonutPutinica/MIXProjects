using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 50.0f;
    [SerializeField]
    private GameObject player;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0.0f)
        {
            PlayerDeath();
        }
    }

    private void PlayerDeath()
    {
        Debug.Log("PLAYER HAS NO MORE HEALTH!");
        player.SetActive(false);
    }
}
