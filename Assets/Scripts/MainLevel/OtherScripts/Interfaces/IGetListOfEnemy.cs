using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGetListOfEnemy
{
    public List<GameObject> GetEnemyOfThisShip();
    public void SetEnemyOfThisShip(List<GameObject> value);
}
