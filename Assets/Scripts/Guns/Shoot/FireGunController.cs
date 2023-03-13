using UnityEngine;

public class FireGunController : MonoBehaviour, IStandardShoot
{
    public void Shoot()
    {
        print("Fire Gun is shooting");
    }

}
