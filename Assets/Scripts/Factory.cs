using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Factory : MonoBehaviour
{
    //[SerializeField] List<Factory> factories;

    public abstract void CreateWeapon();
    public IEnumerator DestroyObj(GameObject obj, float wait)
    {
        yield return new WaitForSeconds(wait);
        Destroy(obj);
    }
}
