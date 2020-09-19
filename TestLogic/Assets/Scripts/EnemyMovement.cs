using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //private Quaternion fromRotate = Quaternion.Euler(new Vector3(0.0f, 45.0f, 0.0f));
    //private Quaternion toRotate = Quaternion.Euler(new Vector3(0.0f, -45.0f, 0.0f));
    private float rotateSpeed = 2.0f;
    private float rotationRange = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localRotation = Quaternion.Lerp(fromRotate, toRotate, Time.time * rotateSpeed);
        transform.rotation = Quaternion.Euler(0.0f, rotationRange * Mathf.Sin(Time.time * rotateSpeed), 0.0f);
    }
}
