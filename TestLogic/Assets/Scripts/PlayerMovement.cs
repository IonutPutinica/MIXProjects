using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveHorizontal;
    private float moveVertical;
    private float rotateHorizontal;

    public float speed;
    public float turnSpeed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        rotateHorizontal = Input.GetAxis("Rotate");
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Rotate(Vector3.up * rotateHorizontal * turnSpeed * Time.deltaTime);

        rb.AddForce(movement * speed);

    }
}
