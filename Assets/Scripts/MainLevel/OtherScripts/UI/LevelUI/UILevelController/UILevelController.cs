public class UILevelController
{
    public void SetHPAndShield(LevelUIData levelUIData,float hp, float shield)
    {
        levelUIData.HealthLine.fillAmount = hp * levelUIData.GetMultiplierForHPAndShield(hp);
        levelUIData.ShieldLine.fillAmount = shield * levelUIData.GetMultiplierForHPAndShield(shield);
    }
}
