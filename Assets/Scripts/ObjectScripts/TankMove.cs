using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AudioSource))]
public class TankMove : MonoBehaviour
{
    [SerializeField] Vector3 moveDir;
    [SerializeField] int moveSpeed;
    [SerializeField] int rotateSpeed;
    [SerializeField] Bullet BulletPrefab;
    [SerializeField] Transform bulletPoint;
    [SerializeField] float repeatTime;
    [SerializeField] float coolTime;
    [SerializeField] AudioClip ShotFireing;

    AudioSource audioSource;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        Move();
        Rotate();

    }

    void Move()
    {
        transform.Translate(moveDir* moveSpeed * Time.deltaTime);
        
    }

    

    public void Rotate()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime * moveDir.x);    
    }


    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;

    }

   public void Fire()
    {
        Instantiate(BulletPrefab, bulletPoint.position, bulletPoint.rotation);
        animator.SetTrigger("Fire");
    }
    /// <summary>
    /// �⺻ �߻�
    /// </summary>
    public Coroutine bulletRoutine;

    public void OnFire(InputValue value)
    {
        Fire();
        
    }


    /// <summary>
    /// ����
    /// </summary>
    /// <param name="value"></param>
    public void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("�߻�");
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
            
        }
        else
        {
            Debug.Log("�߻� ����");
            StopCoroutine(bulletRoutine);
            
        }
    }
    IEnumerator BulletMakeRoutine()
    {
        while(true)
        {
            Instantiate(BulletPrefab, bulletPoint.position, bulletPoint.rotation);
            animator.SetTrigger("Fire");
            PLaySoundSfx(ShotFireing);
            yield return new WaitForSeconds(repeatTime);
        }
        
    }
    public void PLaySoundSfx(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
   
}
