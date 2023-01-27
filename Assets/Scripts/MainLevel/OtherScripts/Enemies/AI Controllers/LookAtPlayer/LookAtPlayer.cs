using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer
{
    public void RotateOnPlayer(GameObject enemyShip, GameObject player)
    {
        enemyShip.transform.LookAt(player.transform.position);
    }
}
