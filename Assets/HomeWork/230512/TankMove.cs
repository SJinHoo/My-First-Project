using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMove : MonoBehaviour
{
    
    public Vector3 moveDir;
    [SerializeField]
    public int moveSpeed;
    [SerializeField]
    public int JumpPower;
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
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }

    void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
        Move();
    }
}
