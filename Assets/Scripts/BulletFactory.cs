using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : Factory
{
    [SerializeField] GameObject BulletPrefab;
    [SerializeField] float delay;
    public override void CreateWeapon()
    {
        GameObject obj = Instantiate(BulletPrefab);
        obj.GetComponent<Bullet>().Fire();
        StartCoroutine(DestroyObj(obj, delay));
    }

}
