using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TransformPractice : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float rotateSpeed;
    Vector3 moveDir;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Rotate();
        
        Move();
    }
    void Move()
    {
        transform.Translate(moveDir * moveSpeed *  Time.deltaTime);
    }
    void TransLateMove()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);  // Using Vector
        transform.Translate(0,0, moveSpeed * Time.deltaTime, Space.Self );   // Translate( x,y,z, Space RelativeTo )    
    }

    void TransformMoveSpace()
    {
        transform.Translate(1, 0, 0, Space.World);  // 월드기준
        transform.Translate(1, 0, 0, Space.Self);   // 로컬 기준 (본인 바라보는 기준)
        transform.Translate(1, 0, 0, Camera.main.transform);    // 메인 카메라 좌표  기준
    }

    void Rotate()
    {
        // 축을 이용한 회전 (축을 기준으로 시계방향으로 회전)
        //transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // 오일러를 이용한 회전
        //transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // x,y,z를 이용한 회전
        transform.Rotate(0,1,0);
    }

    void LookAt()
    {
        transform.LookAt(new Vector3(0,0,0));   // Vector 위치를 바라봄
    }

    void Rotation()
    {
        transform.position = new Vector3(0, 0, 0);
        
        // 트랜스폼의 회전값은 Euler의 각도표현이 아닌 Quternion을 사용
        transform.rotation = Quaternion.identity;

        //Euler의 각도를 Quternion으로 변환
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    private void TransformParent()
    {
        GameObject obj = new GameObject() { name = "NewGameObject" };

        //부모 지정해줌
        transform.parent = obj.transform;

        // 부모를 기준으로한 트랜스폼
        // transform.localPosition	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 위치
        // transform.localRotation	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 회전
        // transform.localScale		: 부모트랜스폼이 있는 경우 부모를 기준으로 한 크기

        // 부모가 없는 월드기준으로 로컬이 잡히게됨


        // 부모를 해제함
        transform.parent = null;            // 부모 transform이 없는 모든 게임 오브젝트는 월드기준으로 잡힘

        // 월드를 기준으로한 트랜스폼
        // transform.localPosition == transform.position	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 위치
        // transform.localRotation == transform.rotation	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 회전
        // transform.localScale	                            : 부모트랜스폼이 없는 경우 월드를 기준으로 한 크기

        void OnMove(InputValue value)
        {
            moveDir.x = value.Get<Vector2>().x;
            moveDir.z = value.Get<Vector2>().y;
        }
    }
}

    

