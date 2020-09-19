using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float damage = 10.0f;
    public float range = 100.0f;
    RaycastHit hit;

    private void FixedUpdate() //Raycast works with Unity physics and its best to keep physics in fixed update.
    {
        if (Physics.Raycast(transform.position, transform.forward * -1, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            //Debug.Log("The ENEMY shot the PLAYER!");
            if (hit.transform.name == "PlayerCube")
            {
                Debug.Log("DIE!");
                //StartCoroutine(OpenFire());
                //The method below may get moved to the coroutine.
                PlayerHealth player = hit.transform.GetComponent<PlayerHealth>();
                if (player != null)
                {
                    player.TakeDamage(damage);
                }
            }
            else
            {
                Debug.Log("SEARCHING!");
            }
        }
    }

    IEnumerator OpenFire()
    {
        while(hit.collider != null)
        {
            //stop rotation from movement script and fire at the player
        }
        yield return null;
    }
}
