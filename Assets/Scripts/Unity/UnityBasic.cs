using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    public AudioSource audioSource;

    public void Start()
    {
        GameObjectBasic();
        ComponentBasic();
    }
    public void GameObjectBasic()
    {
        // < 게임오브젝트 접근 >
        // 컴포넌트가 붙어 있는 게임오브젝트는 gameObject 속성을 이용하여 접근가능
        gameObject.name = "Player";

        // 컴포넌트가 붙어있는 게임오브젝트

        // gameObject.name;                 // 게임오브젝트의 이름 접근
        // gameObject.active;               // 게임오브젝트의 활성화 여부 접근
        // gameObject.tag;                  // 게임오브젝트의 태그 접근
        // gameObject.layer;                // 게임오브젝트의 레이어 접근

        // 게임오브젝트 탐색
        GameObject.Find("Player");                     // 이름으로 찾기
        GameObject.FindGameObjectWithTag("Player");    // 태그로 찾기
        GameObject.FindGameObjectsWithTag("Player");   // 태그 모두 찾기
       

        // < 게임오브젝트 생성 >
        GameObject newObject = new GameObject();

        //newObject.name = " New Game Onject ";

        // < 게임오브젝트 삭제 > 
        Destroy(gameObject , 5f);
        
        // 삭제되는 시간을 지연 시키고 싶은경우 ( 삭제하고자하는 GameObject, 삭제 시간 )
    }

    
    public void ComponentBasic()
    {
        // < 게임오브젝트 내 컴포넌트 접근 >
        GetComponent<AudioSource>();                        // 컴포넌트에서 GetComponent를 사용
        gameObject.GetComponent<AudioSource>();             // 게임옵젝의 컴포넌트 접근
        gameObject.GetComponents<AudioSource>();            // 게임옵젝의 여러 컴포넌트 접근

        GetComponentInChildren<AudioSource>();                // 자식게임오브젝트 포함 컴포넌트 접근
        GetComponentsInChildren<AudioSource>();               // 자식게임오브젝트 포함 여러 컴포넌트 접근
        gameObject.GetComponentInChildren<AudioSource>();     // 게임오브젝트의 자식게임오브젝트 포함 컴포넌트 접근
        gameObject.GetComponentsInChildren<AudioSource>();    // 게임오브젝트의 자식게임오브젝트 포함 여러 컴포넌트 접근

        gameObject.GetComponentInParent<AudioSource>();       // 부모 게임오브젝트 포함 컴포넌트 접근
        gameObject.GetComponentsInParent<AudioSource>();	  // 부모 게임오브젝트 포함 컴포넌트들 접근


        // <컴포넌트 탐색>
        FindObjectOfType<AudioSource>();                      // 씬 내의 컴포넌트 탐색
        FindObjectsOfType<AudioSource>();                     // 씬 내의 모든 컴포넌트 탐색

        // <컴포넌트 추가>

        // Rigidbody rigid = new Rigidbody();      // 가능하나  의미없음
        gameObject.AddComponent<AudioSource>();     // 게임 오브젝트에 컴포넌트 추가

        // <컴포넌트 삭제>
        Destroy(GetComponent<Collider>());
    }
}
