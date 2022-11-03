using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            List<GameObject> listOfGuns = PlayerData.instance.TakeListOfGuns();
            for (int i = 0; i < listOfGuns.Count; i++)
            {
                if(listOfGuns[i].activeInHierarchy)
                {
                    GameObject obj = listOfGuns[i];
                    IStandardShot shooting = obj.GetComponent<IStandardShot>();
                    shooting.Shoot();
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < PlayerData.instance.TakeListOfAbilities().Count; i++)
            {
                if (PlayerData.instance.TakeListOfAbilities()[i].activeInHierarchy)
                {
                    GameObject obj = PlayerData.instance.TakeListOfAbilities()[i];
                    IAbilities shooting = obj.GetComponent<IAbilities>();
                    shooting.UseAbilities();
                }

            }
        }
    }
}
