using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHead : MonoBehaviour
{
    private float mouseSpeed = 3f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSpeed, 0f, Space.World);
    }
}
