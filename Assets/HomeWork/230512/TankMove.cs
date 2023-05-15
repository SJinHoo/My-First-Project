using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMove : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]  public Vector3 moveDir;
    [SerializeField] public int moveSpeed;
    [SerializeField] public int rotateSpeed;
    [SerializeField] public Bullet BulletPrefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] public float repeatTime;
    


    void Start()
    {

    }


    void Update()
    {
        Move();
        Rotate();

    }

    void Move()
    {
        transform.Translate(Vector3.forward * 10f * moveSpeed * Time.deltaTime * moveDir.z);
    }

    

    public void Rotate()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime * moveDir.x);    
    }


    public void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;

        // Vector2 movedir = value.Get<Vector2>();
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
            Instantiate(BulletPrefab, bulletPoint.position, bulletPoint.rotation);
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
        }
        else
        {
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
