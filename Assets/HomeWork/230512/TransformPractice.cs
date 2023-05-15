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
        transform.Translate(1, 0, 0, Space.World);  // �������
        transform.Translate(1, 0, 0, Space.Self);   // ���� ���� (���� �ٶ󺸴� ����)
        transform.Translate(1, 0, 0, Camera.main.transform);    // ���� ī�޶� ��ǥ  ����
    }

    void Rotate()
    {
        // ���� �̿��� ȸ�� (���� �������� �ð�������� ȸ��)
        //transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // ���Ϸ��� �̿��� ȸ��
        //transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // x,y,z�� �̿��� ȸ��
        transform.Rotate(0,1,0);
    }

    void Rotation()
    {

    }
}
