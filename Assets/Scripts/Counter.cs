using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField]
    BulletType bulletType;
    int count = 0;
    TextMeshProUGUI text;
    private void OnEnable()
    {
        text=GetComponent<TextMeshProUGUI>();
        Shooter.ShootEvent += UpdateCounter;
    }
    void UpdateCounter(BulletType type)
    {
        if (bulletType == type)
            count++;
        text.text=count.ToString();
    }
}
