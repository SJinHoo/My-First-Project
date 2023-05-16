using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]   // �� �ʿ����� ������ �ʿ��ϴٴ� ���� ǥ���ϱ����� �ۼ�.

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip shellExplosion;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject explosionEffect;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);            // 5�ʵ� ����
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            SoundSfx(shellExplosion);
            Destroy(gameObject, 1f);
        }
        
       
    }
    
    public void SoundSfx(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
