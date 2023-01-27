using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromFireGun : MonoBehaviour, IStandardShoot
{
    public void Shoot()
    {
        print("Fire Gun is shooting");
    }

}
