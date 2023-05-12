using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    public int moveSpeed;
    [SerializeField]
    public int jumpPoower;
    [SerializeField]
    private Vector3 moveDir;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        Debug.Log(" 5월 12일 과제 시작!");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(h,0,v) * moveSpeed * Time.deltaTime);
        Debug.Log($"{h},{v}");
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpPoower,ForceMode.Impulse);
    }
    void OnJump(InputValue value)
    {
        Jump();
    }
    void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
}
