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
    [SerializeField]
    public int JumpPower;


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
        transform.Translate(Vector3.forward * 10f * moveSpeed * Time.deltaTime * moveDir.z);
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime * moveDir.x);    
    }


    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;

        // Vector2 movedir = value.Get<Vector2>();
    }

    public void OnJump()
    {
        //TODO
    }



}
