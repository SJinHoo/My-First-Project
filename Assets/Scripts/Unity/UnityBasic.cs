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
        // < ���ӿ�����Ʈ ���� >
        // ������Ʈ�� �پ� �ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
        gameObject.name = "Player";

        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ

        // gameObject.name;                 // ���ӿ�����Ʈ�� �̸� ����
        // gameObject.active;               // ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
        // gameObject.tag;                  // ���ӿ�����Ʈ�� �±� ����
        // gameObject.layer;                // ���ӿ�����Ʈ�� ���̾� ����

        // ���ӿ�����Ʈ Ž��
        GameObject.Find("Player");                     // �̸����� ã��
        GameObject.FindGameObjectWithTag("Player");    // �±׷� ã��
        GameObject.FindGameObjectsWithTag("Player");   // �±� ��� ã��
       

        // < ���ӿ�����Ʈ ���� >
        GameObject newObject = new GameObject();

        //newObject.name = " New Game Onject ";

        // < ���ӿ�����Ʈ ���� > 
        Destroy(gameObject , 5f);
        
        // �����Ǵ� �ð��� ���� ��Ű�� ������� ( �����ϰ����ϴ� GameObject, ���� �ð� )
    }

    
    public void ComponentBasic()
    {
        // < ���ӿ�����Ʈ �� ������Ʈ ���� >
        GetComponent<AudioSource>();                        // ������Ʈ���� GetComponent�� ���
        gameObject.GetComponent<AudioSource>();             // ���ӿ����� ������Ʈ ����
        gameObject.GetComponents<AudioSource>();            // ���ӿ����� ���� ������Ʈ ����

        GetComponentInChildren<AudioSource>();                // �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        GetComponentsInChildren<AudioSource>();               // �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        gameObject.GetComponentInChildren<AudioSource>();     // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        gameObject.GetComponentsInChildren<AudioSource>();    // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����

        gameObject.GetComponentInParent<AudioSource>();       // �θ� ���ӿ�����Ʈ ���� ������Ʈ ����
        gameObject.GetComponentsInParent<AudioSource>();	  // �θ� ���ӿ�����Ʈ ���� ������Ʈ�� ����


        // <������Ʈ Ž��>
        FindObjectOfType<AudioSource>();                      // �� ���� ������Ʈ Ž��
        FindObjectsOfType<AudioSource>();                     // �� ���� ��� ������Ʈ Ž��

        // <������Ʈ �߰�>

        // Rigidbody rigid = new Rigidbody();      // �����ϳ�  �ǹ̾���
        gameObject.AddComponent<AudioSource>();     // ���� ������Ʈ�� ������Ʈ �߰�

        // <������Ʈ ����>
        Destroy(GetComponent<Collider>());
    }
}
