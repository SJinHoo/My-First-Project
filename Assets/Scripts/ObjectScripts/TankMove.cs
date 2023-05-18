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
    /// <summary>
    /// Basic Fire
    /// </summary>
   public void Fire()
    {
        Instantiate(BulletPrefab, bulletPoint.position, bulletPoint.rotation);
        animator.SetTrigger("Fire");
        PLaySoundSfx(ShotFireing);
        
        
    }
    
    public Coroutine bulletRoutine;

    /// <summary>
    /// Input system 사격
    /// </summary>
    /// <param name="value"></param>
    public void OnFire(InputValue value)
    {
        Fire();      
    }


    /// <summary>
    /// 연사
    /// </summary>
    /// <param name="value"></param>
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

    /// <summary>
    /// 연사 코루틴
    /// </summary>
    /// <returns></returns>
    IEnumerator BulletMakeRoutine()
    {
        while(true)
        {
            Fire();
            yield return new WaitForSeconds(repeatTime);
        }
        
    }

    /// <summary>
    /// SFX 클립 함수
    /// </summary>
    /// <param name="clip"></param>
    public void PLaySoundSfx(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
   
}
