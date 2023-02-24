using System.Collections.Generic;
using UnityEngine;

public class PageButtons : MonoBehaviour
{
    [SerializeField] private DataWeaponsPanel weaponsPanelData;

    public void NextPage()
    {
        List<GameObject> listOfPagePanels = weaponsPanelData.PagesOfGunsPanels;
        int amount = listOfPagePanels.Count;
        int lastObjectOfList = amount - 1;
        for (int i = 0; i < amount; i++)
        {
            if (weaponsPanelData.CurrentPanel == listOfPagePanels[i])
            {
                listOfPagePanels[i].SetActive(false);

                if (i == lastObjectOfList)
                {
                    listOfPagePanels[0].SetActive(true);
                    weaponsPanelData.CurrentPanel = listOfPagePanels[0];
                    weaponsPanelData.PagesText.SetText("1/" + amount);
                }
                else
                {
                    listOfPagePanels[i + 1].SetActive(true);
                    weaponsPanelData.CurrentPanel = listOfPagePanels[i + 1];
                    weaponsPanelData.PagesText.SetText(i + 2 + "/" + amount);
                }
                return;
            }
        }
    }

    public void LastPage()
    {
        List<GameObject> listOfPagePanels = weaponsPanelData.PagesOfGunsPanels;
        int amount = listOfPagePanels.Count;
        int lastObjectOfList = amount - 1;
        for (int i = 0; i < amount; i++)
        {
            if (weaponsPanelData.CurrentPanel == listOfPagePanels[i])
            {
                listOfPagePanels[i].SetActive(false);
                if (i == 0)
                {
                    listOfPagePanels[lastObjectOfList].SetActive(true);
                    weaponsPanelData.CurrentPanel = listOfPagePanels[lastObjectOfList];
                    weaponsPanelData.PagesText.SetText(lastObjectOfList + 1 + "/" + amount);
                }
                else
                {
                    listOfPagePanels[i - 1].SetActive(true);
                    weaponsPanelData.CurrentPanel = listOfPagePanels[i - 1];
                    weaponsPanelData.PagesText.SetText(i + "/" + amount);
                }
                return;
            }
        }
    }
}
