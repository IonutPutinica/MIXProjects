using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private EnemyShoot enemyShoot;
    private float rotateSpeed = 2.0f;
    private float rotationRange = 75.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyShoot = GameObject.FindObjectOfType<EnemyShoot>();
        StartCoroutine(Search());
    }

    public IEnumerator Search()
    {
        var oscillate = StartCoroutine(Oscillate());
        while(!enemyShoot.FoundPlayer())
        {
            yield return null;
        }
        Debug.Log("Player Found by Enemy!");
        StopCoroutine(oscillate);
        StartCoroutine(enemyShoot.Fire());
    }

    private IEnumerator Oscillate()
    {
        while(true)
        {
            transform.rotation = Quaternion.Euler(0.0f, rotationRange * Mathf.Sin(Time.time * rotateSpeed), 0.0f);
            Debug.Log("Searching!");
            yield return null;
        }
    }
}
