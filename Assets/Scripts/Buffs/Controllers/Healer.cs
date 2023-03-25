using ShipData;
using UnityEngine;

public class Healer : MonoBehaviour, IBuffUse
{
    [SerializeField] private bool _healHP;
    [SerializeField] private bool _healShield;

    [SerializeField] private float _reHealHP;
    [SerializeField] private float _reHealShield;

    public void UseBuff(GameObject objWithBuff)
    {
        PlayerData playerData = objWithBuff.GetComponent<PlayerData>();
        CheckIsShieldMoreZero(playerData);

        if (_healHP)
        {
            AddHP(playerData);
        }
        if (_healShield)
        {
            AddShield(playerData);
        }
    }
    
    private void CheckIsShieldMoreZero(PlayerData playerData)
    {
        if(playerData.GetShield() < 0)
        {
            playerData.SetShield(0);
        }
    }
    private void AddHP(PlayerData playerData)
    {
        float hpAfterHeal = playerData.StartHP - (playerData.GetHealth() + _reHealHP);
        if (hpAfterHeal >= 0)
        {
            float curentHP = playerData.GetHealth();
            playerData.SetHealth(curentHP + _reHealHP);

            Destroy(gameObject);
        }
        else
        {
            float addHp = _reHealHP + hpAfterHeal;

            float curentHP = playerData.GetHealth();
            playerData.SetHealth(curentHP + addHp);

            Destroy(gameObject);
        }
    }
    private void AddShield(PlayerData playerData)
    {
        float shieldAfterHeal = playerData.StartShield - (playerData.GetShield() + _reHealShield);
        if (shieldAfterHeal >= 0)
        {
            float curentHP = playerData.GetShield();
            playerData.SetShield(curentHP + _reHealShield);

            Destroy(gameObject);
        }
        else
        {
            float addShield = _reHealShield + shieldAfterHeal;

            float curentShield = playerData.GetShield();
            playerData.SetShield(curentShield + addShield);

            Destroy(gameObject);
        }
    }
}
