using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static 변수로 instance 변수를 가지도록 만들어주고
    private static GameManager instance;
    private static DataManager dataManager;

    // instance 프로퍼티 생성
    public static GameManager Instance { get { return instance; } }
    public static DataManager Data { get { return dataManager; } }
    private void Awake()
    {
        // 인스턴스가 null이 아닌 경우
        if(instance != null)
        {
            Destroy(this);  // 해당 인스턴스를 파괴
            return;
        }
        // Gamemanager.instance 가 사라지지 않게하기 위한 함수
        instance = this;
        DontDestroyOnLoad(this);
        InitManagers();
    }
    // inspector 창에서 instance(GameManager) 생성가능 하기 때문에 기존의 싱글톤 방식과는 다름
    private void OnDestroy()
    {
        if(instance == this)
            instance = null;
    }

    private void InitManagers()
    {
        
        GameObject dataObj = new GameObject() { name = "DataManager" };
        dataObj.transform.SetParent(transform);
        dataManager = dataObj.AddComponent<DataManager>();
    }

    
}
