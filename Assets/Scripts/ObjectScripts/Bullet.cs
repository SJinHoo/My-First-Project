using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]   // 꼭 필요하진 않으나 필요하다는 것을 표시하기위해 작성.

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float bulletSpeed;
    [SerializeField] private GameObject explosionEffect;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);            // 5초뒤 삭제
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
}
