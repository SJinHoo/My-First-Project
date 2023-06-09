using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] Bullet BulletPrefab;
    [SerializeField] Transform bulletPoint;
    [SerializeField] float repeatTime;

    private Animator animator;

    public UnityEvent OnFired;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Fire()
    {
        Instantiate(BulletPrefab, bulletPoint.position, bulletPoint.rotation);
        
        OnFired?.Invoke();

        GameManager.Data.AddShootCount(1);
    }

    public Coroutine bulletRoutine;
    public void OnFire(InputValue value)
    {
        Fire();
        
    }

    public void OnRapidFire(InputValue value)
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
        while (true)
        {
            Fire();
            yield return new WaitForSeconds(repeatTime);
        }

    }

    public void Test(int count)
    {
        Debug.Log($"데이터의 슛 카운트가 {count}로 바뀜");
    }
}
