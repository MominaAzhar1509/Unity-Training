using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BulletType
{
    Bullet=0,
    Missile=1,
    Grenade=2
}
public class Shooter : MonoBehaviour
{
    [SerializeField]
    BulletType bulletType;

    public delegate void OnShoot(BulletType type);
    public static event OnShoot ShootEvent;


    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(InvokeShootEvent);
    }
    void InvokeShootEvent()
    {
        ShootEvent?.Invoke(bulletType);
    }
}
