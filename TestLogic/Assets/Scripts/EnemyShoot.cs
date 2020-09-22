using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private EnemyMovement movement;

    public float damage = 10.0f;
    public float range = 100.0f;
    RaycastHit hit;

    private void Start()
    {
        movement = GameObject.FindObjectOfType<EnemyMovement>();
    }

    public bool FoundPlayer()
    {
        Debug.DrawRay(transform.position, transform.forward * -50, Color.red);
        if (!Physics.Raycast(transform.position, transform.forward * -1, out hit, range))
        {
            return false;
        }
        return hit.transform.name == "PlayerCube";
    }
    
    public IEnumerator Fire()
    {
        while(FoundPlayer())
        { 
            Debug.Log("Is Called.");
            yield return new WaitForSeconds(2f);
        }
        StartCoroutine(movement.Search());
        //Problem here.  It restarts the movement rather than continuing where it left off.
        //Also it should restart the coroutine based on the player remaining in the raycast.
    }

}
