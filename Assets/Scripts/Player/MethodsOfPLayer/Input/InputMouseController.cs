using UnityEngine;
using ShipData;

namespace InputDeviceControllers
{
    public class InputMouseController
    {
        public void InputController(PlayerData playerData)
        {
            if (!playerData.IsAccelerated)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    ShootFromGun shootFromGun = new ShootFromGun();
                    shootFromGun.ShootPlayerGuns(playerData);
                }
                if (Input.GetMouseButtonDown(1))
                {
                    for (int i = 0; i < playerData.TakeListOfAbilities().Count; i++)
                    {
                        if (playerData.TakeListOfAbilities()[i].activeInHierarchy)
                        {
                            GameObject obj = playerData.TakeListOfAbilities()[i];
                            IAbilities shooting = obj.GetComponent<IAbilities>();
                            shooting.UseAbilities();
                        }

                    }
                }
            }
        }
    }
}
