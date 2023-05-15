using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMove : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 moveDir;
    [SerializeField]
    public int moveSpeed;
    [SerializeField]
    public int rotateSpeed;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        Rotate();
        
    }
    
    void Move()
    {
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);    // y 기준 회전
    }

    void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
        Move();
    }

    

    
}
