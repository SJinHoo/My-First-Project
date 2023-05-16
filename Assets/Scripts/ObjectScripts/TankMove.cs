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
    [SerializeField] AudioClip fireSfx;
    [SerializeField] AudioSource audioSource = null;
    
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
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * moveDir.z);
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

    /// <summary>
    /// 기본 발사
    /// </summary>
    public Coroutine bulletRoutine;

    public void OnFire(InputValue value)
    {
         Instantiate(BulletPrefab, bulletPoint.position, bulletPoint.rotation);       
    }


    /// <summary>
    /// 연사
    /// </summary>
    /// <param name="value"></param>
    public void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("발사");
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
        }
        else
        {
            Debug.Log("발사 중지");
            StopCoroutine(bulletRoutine);
            
        }
    }
    IEnumerator BulletMakeRoutine()
    {
        while(true)
        {
            Instantiate(BulletPrefab, bulletPoint.position, bulletPoint.rotation);
            yield return new WaitForSeconds(repeatTime);
        }
        
    }

   
}
