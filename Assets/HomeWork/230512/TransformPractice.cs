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

    void LookAt()
    {
        transform.LookAt(new Vector3(0,0,0));   // Vector ��ġ�� �ٶ�
    }

    void Rotation()
    {
        transform.position = new Vector3(0, 0, 0);
        
        // Ʈ�������� ȸ������ Euler�� ����ǥ���� �ƴ� Quternion�� ���
        transform.rotation = Quaternion.identity;

        //Euler�� ������ Quternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    private void TransformParent()
    {
        GameObject obj = new GameObject() { name = "NewGameObject" };

        //�θ� ��������
        transform.parent = obj.transform;

        // �θ� ���������� Ʈ������
        // transform.localPosition	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ��ġ
        // transform.localRotation	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ȸ��
        // transform.localScale		: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ũ��

        // �θ� ���� ����������� ������ �����Ե�


        // �θ� ������
        transform.parent = null;            // �θ� transform�� ���� ��� ���� ������Ʈ�� ����������� ����

        // ���带 ���������� Ʈ������
        // transform.localPosition == transform.position	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ��ġ
        // transform.localRotation == transform.rotation	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ȸ��
        // transform.localScale	                            : �θ�Ʈ�������� ���� ��� ���带 �������� �� ũ��

        void OnMove(InputValue value)
        {
            moveDir.x = value.Get<Vector2>().x;
            moveDir.z = value.Get<Vector2>().y;
        }
    }
}

    

