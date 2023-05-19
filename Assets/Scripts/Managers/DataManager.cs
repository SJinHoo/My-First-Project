using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] private int shootCount;
    public UnityAction<int> OnShootCountChanged;
    public void AddShootCount(int count)
    {
        shootCount += count;
        OnShootCountChanged?.Invoke(shootCount);
    }
}
