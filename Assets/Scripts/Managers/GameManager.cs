using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static ������ instance ������ �������� ������ְ�
    private static GameManager instance;
    private static DataManager dataManager;

    // instance ������Ƽ ����
    public static GameManager Instance { get { return instance; } }
    public static DataManager Data { get { return dataManager; } }
    private void Awake()
    {
        // �ν��Ͻ��� null�� �ƴ� ���
        if(instance != null)
        {
            Destroy(this);  // �ش� �ν��Ͻ��� �ı�
            return;
        }
        // Gamemanager.instance �� ������� �ʰ��ϱ� ���� �Լ�
        instance = this;
        DontDestroyOnLoad(this);
        InitManagers();
    }
    // inspector â���� instance(GameManager) �������� �ϱ� ������ ������ �̱��� ��İ��� �ٸ�
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
