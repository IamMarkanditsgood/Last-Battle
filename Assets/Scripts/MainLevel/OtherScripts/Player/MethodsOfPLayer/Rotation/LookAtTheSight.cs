using UnityEngine;
using ShipData;

namespace LookAtMethods
{
    public class LookAtTheSight
    {
        public void LookAtCursor(PlayerData playerData, GameObject playerShip)
        {
            playerShip.transform.LookAt(playerData.Sight.transform, Vector3.up);
        }
    }
}
