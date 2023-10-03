using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    Rigidbody rb;
    int force = 120;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force);
        }
    }
}
