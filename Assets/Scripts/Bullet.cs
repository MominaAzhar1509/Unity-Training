using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IWeapon
{

    [SerializeField] int damage;
    [SerializeField] int speed;
    public void Fire()
    {
        //Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
        GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }
}
