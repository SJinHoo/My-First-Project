using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShellEvent : MonoBehaviour
{
    public UnityEvent shellExplosion;
    void Start()
    {
        shellExplosion?.Invoke();
        Destroy(gameObject,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
