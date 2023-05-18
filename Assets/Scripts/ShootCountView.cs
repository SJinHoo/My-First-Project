using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class ShootCountView : MonoBehaviour
{
    
    private TMP_Text textView;      

    private void Awake()
    {
        textView = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        //GameManager.Data.OnShootCountChanged += ChangeText;
    }

    private void OnDisable()
    {
       // GameManager.Data.OnShootCountChanged -= ChangeText;
    }

    private void ChangeText(int count)
    {
        textView.text = count.ToString();
    }

}
