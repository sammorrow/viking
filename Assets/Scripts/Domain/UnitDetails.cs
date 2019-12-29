using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Unit Details")]
public class UnitDetails : ScriptableObject
{
    public string unitName;
    public string unitTitle;
    public Sprite unitPortrait;
    public int healthBase;
    public int healthBonus;
    public int healthCurrent;
    public int loyaltyBase;
    public int loyaltyBonus;
    public int loyaltyCurrent;

    //TODO: Item system
    public string unitWeapon;
    public string unitArmor;

    public int GetHealthTotal()
    {
        return healthBase + healthBonus;
    }

    public int GetLoyaltyTotal()
    {
        return loyaltyBase + loyaltyBonus;
    }

    public string GetFullName()
    {
        return unitName + " " + unitTitle;
    }
}
