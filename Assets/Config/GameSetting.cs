using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ������ �ؾ��� �۾����� ����
public class GameSetting
{
    //�������ڸ��� ȣ��Ǵ� �Լ��� �̱����� ���� ������ ���۵Ǵ� ������ �������� �ڵ�
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    
    private static void Init()
    {
        // ���� �������� �ʿ��� ������
        if(GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = " GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }
}
