using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOfBullet : MonoBehaviour
{
    private void FixedUpdate()
    {
        ProjectileController();
    }
    public void ProjectileController()
    {
        DataOfProjectile dataOfProjectile = GetComponent<DataOfProjectile>();
        transform.Translate(Vector3.forward * dataOfProjectile.ScriptableObjects.Speed * Time.deltaTime);
    }
}
