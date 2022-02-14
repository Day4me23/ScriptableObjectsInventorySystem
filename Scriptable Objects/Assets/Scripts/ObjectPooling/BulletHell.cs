using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHell : MonoBehaviour
{
    public Transform firePoint;
    public ObjectPool bulletPool;

    void Update()
    {
        bulletPool.SpawnObject(firePoint.position, firePoint.rotation);
    }
}
