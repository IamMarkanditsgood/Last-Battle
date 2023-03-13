using System.Collections.Generic;
using UnityEngine;

public class MainButtonsOfShop : MonoBehaviour
{
    [SerializeField] private MainDatas _mainData;

    private SoundsController _soundsController = new SoundsController();

    public void NextPanel()
    {
        _soundsController.UseSound(ETypeOfSound.ButtonSound);
        List<GameObject> listOfShopsPanels = _mainData.PanelsOfShop;
        int amount = listOfShopsPanels.Count;
        int lastObjectOfList = amount - 1;
        for (int i =0; i < amount; i++)
        {
            if (_mainData.CurrentPanel == listOfShopsPanels[i])
            {
                print("good");
                listOfShopsPanels[i].SetActive(false);
                
                if (i == lastObjectOfList)
                {
                    listOfShopsPanels[0].SetActive(true);
                    _mainData.CurrentPanel = listOfShopsPanels[0];
                }
                else
                {
                    listOfShopsPanels[i + 1].SetActive(true);
                    _mainData.CurrentPanel = listOfShopsPanels[i+1];
                }
                return;
            }
        }
    }
    public void LastPanel()
    {
        _soundsController.UseSound(ETypeOfSound.ButtonSound);
        List<GameObject> listOfShopsPanels = _mainData.PanelsOfShop;
        int amount = listOfShopsPanels.Count;
        int lastObjectOfList = amount - 1;
        for (int i = 0; i < amount; i++)
        {
            if (_mainData.CurrentPanel == listOfShopsPanels[i])
            {
                listOfShopsPanels[i].SetActive(false);
                if (i == 0)
                {
                    listOfShopsPanels[lastObjectOfList].SetActive(true);
                    _mainData.CurrentPanel = listOfShopsPanels[lastObjectOfList];
                }
                else
                {
                    listOfShopsPanels[i - 1].SetActive(true);
                    _mainData.CurrentPanel = listOfShopsPanels[i-1];

                }
                return;
            }
        }
    }
}
