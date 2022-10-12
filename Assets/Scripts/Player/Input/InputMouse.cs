using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for(int i = 0; i < PlayerData.instance.ListOfGans.Count; i++)
            {
                if(PlayerData.instance.ListOfGans[i].activeInHierarchy)
                {
                    GameObject obj = PlayerData.instance.ListOfGans[i];
                    IStandardShot shooting = obj.GetComponent<IStandardShot>();
                    shooting.Shoot();
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < PlayerData.instance.ListOfAbilities.Count; i++)
            {
                if (PlayerData.instance.ListOfAbilities[i].activeInHierarchy)
                {
                    GameObject obj = PlayerData.instance.ListOfAbilities[i];
                    IAbilities shooting = obj.GetComponent<IAbilities>();
                    shooting.UseAbilities();
                }

            }
        }
    }
}
