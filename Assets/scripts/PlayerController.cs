using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigid;
    private float mouseSpeed = 3f;
    

    public int JumpPower;
    public int MoveSpeed;

    public bool IsJumping;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        transform.Rotate(0f, Input.GetAxis("Mouse X") * mouseSpeed, 0f, Space.World);
        
        
    }
    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate((new Vector3(h, 0, v) * MoveSpeed) * Time.deltaTime);
               
        
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsJumping)
            {
                Debug.Log("공중에서는 점프 불가능");
                IsJumping = true;
                rigid.AddForce(Vector3.up*JumpPower, ForceMode.Impulse);
            }

            
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 바닥에 있는 경우
        if (collision.gameObject.CompareTag("Ground"))
        {
            //점프가 가능한 상태로 만들어줌
            Debug.Log("점프 가능");
            IsJumping = false;
        }
    }
}
