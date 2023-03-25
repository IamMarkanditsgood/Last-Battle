using TMPro;
using UnityEngine;

public class UILevelController: MonoBehaviour
{
    [SerializeField] private LevelUIData _levelUIData;

    private LevelData _levelData;

    private void Start()
    {
        _levelData = LevelData.instance;
    }

    private void Update()
    {
        SetScoreAndMoney();
        if (_levelData.LoseLevel)
        {
           _levelUIData.EndPanel.SetActive(true);
        }
    }
    public void SetScoreAndMoney()
    {
        TextMeshProUGUI Text = _levelUIData.Money.GetComponent<TextMeshProUGUI>();

        Text.SetText("Money: " + _levelData.Money);

        Text = _levelUIData.Score.GetComponent<TextMeshProUGUI>();
        Text.SetText("Score: " + _levelData.Score);
    }
}
