using UnityEngine;

public class TouchingObjects
{
    public void CheckingObjectLayer(Collider collision, GameObject bullet)
    {
        EffectController effectController = new EffectController();
        SoundsController soundsController = new SoundsController();
        DataOfProjectile dataOfProjectile = bullet.GetComponent<DataOfProjectile>();

        if (collision.gameObject.layer == LayerMask.NameToLayer("Meteorite"))
        {
            CleanPrefab cleanPrefab = new CleanPrefab();

            UseEffectAndSound(dataOfProjectile, bullet);

            bullet.SetActive(false);
            cleanPrefab.CleanProjectile(bullet);
        }
        else if (dataOfProjectile.OwnersShip.layer != collision.gameObject.layer)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                ImplementInteractionWithObject(dataOfProjectile, bullet, collision, false);
            }
            else if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                ImplementInteractionWithObject(dataOfProjectile, bullet, collision, true);
            }
        }
    }
    public void CheckingObjectLayer(GameObject collision, GameObject bullet)// For Lazer Gun
    {
        
    }
    private void ImplementInteractionWithObject(DataOfProjectile dataOfProjectile, GameObject bullet, Collider collision, bool isPlayer)
    {
        CleanPrefab cleanPrefab = new CleanPrefab();
        HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();

        float damage = dataOfProjectile.Damage * dataOfProjectile.DamageIndex;
        healtheAndShieldController.TakeDamage(collision.gameObject, damage, isPlayer);

        UseEffectAndSound(dataOfProjectile, bullet);

        bullet.SetActive(false);
        cleanPrefab.CleanProjectile(bullet);
    }
    private void UseEffectAndSound(DataOfProjectile dataOfProjectile, GameObject bullet)
    {
        EffectController effectController = new EffectController();
        SoundsController soundsController = new SoundsController();

        effectController.UseEffect(dataOfProjectile.ScriptableObjects.TypeOfEffect, bullet.transform);
        soundsController.UseSound(dataOfProjectile.ScriptableObjects.TypeOfSound, bullet);
    }
}
