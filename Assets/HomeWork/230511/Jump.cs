using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int JumpPower;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jumping();
    }

    void Update()
    {

    }

    void Jumping()
    {
        rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }
}
