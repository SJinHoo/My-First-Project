using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 시작전 해야할 작업들을 세팅
public class GameSetting
{
    //시작하자마자 호출되는 함수로 싱글톤이 없이 게임이 시작되는 현상을 막기위한 코드
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    
    private static void Init()
    {
        // 게임 시작전에 필요한 설정들
        if(GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = " GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }
}
