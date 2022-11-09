using System.Collections.Generic;
using UnityEngine;
using ShipData;

namespace InputDeviceControllers
{
    public class InputMouseController
    {
        public void InputController(PlayerData playerData)
        {
            if (Input.GetMouseButtonDown(0))
            {
                List<GameObject> listOfGuns = playerData.TakeListOfGuns();
                for (int i = 0; i < listOfGuns.Count; i++)
                {
                    if (listOfGuns[i].activeInHierarchy)
                    {
                        GameObject obj = listOfGuns[i];
                        IStandardShot shooting = obj.GetComponent<IStandardShot>();
                        shooting.Shoot();
                    }
                }
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
