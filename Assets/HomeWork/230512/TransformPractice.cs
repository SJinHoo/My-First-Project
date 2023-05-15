using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPractice : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        Rotate();
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

    void Rotation()
    {

    }
}
