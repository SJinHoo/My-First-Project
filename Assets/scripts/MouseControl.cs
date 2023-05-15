using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    [SerializeField] float MrotSpeed;
    [SerializeField] 
    void Start()
    {
        
    }

    
    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        float MouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * MrotSpeed * MouseX);

    }

    
}
