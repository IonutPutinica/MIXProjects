using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private PlayerFX playerEffect;

    public float damage = 10.0f;
    public float range = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerEffect = GameObject.FindObjectOfType<PlayerFX>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            playerEffect.ShotsFired();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Debug.DrawRay(transform.position, transform.forward * -50, Color.green);
            Debug.Log(hit.transform.name);
            Debug.Log("The PLAYER shot the ENEMY!");

            EnemyHealth enemy = hit.transform.GetComponent<EnemyHealth>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
