using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{
    public int JumpPower;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jump();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }
}
