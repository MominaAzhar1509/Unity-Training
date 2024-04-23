using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] List<Factory> factories;
    private void OnEnable()
    {
        Shooter.ShootEvent += Shoot;
    }
    public void Shoot(BulletType type)
    {
        int index = (int)type;
        if(index < factories.Count)
            factories[index].CreateWeapon();
    }
}
