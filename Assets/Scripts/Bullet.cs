using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]   // �� �ʿ����� ������ �ʿ��ϴٴ� ���� ǥ���ϱ����� �ۼ�.

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float bulletSpeed;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);            // 5�ʵ� ����
    }

    
}
