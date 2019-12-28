﻿using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Unit Details")]
public class UnitDetails : ScriptableObject
{
    public string unitName;
    public string unitTitle;
    public Sprite unitPortrait;
    public int healthBase;
    public int healthBonus;
    public int loyaltyBase;
    public int loyaltyBonus;

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
}