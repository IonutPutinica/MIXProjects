using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(ScanForInteractiveObject), 2.0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScanForInteractiveObject()
    {
        Interactive hitObject = null;
        Vector3 startLocation = this.transform.position;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward,out hit, 100f)) {

            hitObject = hit.collider.GetComponent<Interactive>();

            if (hitObject != null)
                hitObject.LookedAt("Player is viewing interactive object");
        }
    }
}
