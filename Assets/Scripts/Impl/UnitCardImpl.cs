using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitCardImpl : MonoBehaviour
{
    public UnitDetails details;

    public Text fullName;
    public Image portrait;
    public Text health;
    public Text loyalty;
    public Text armor;
    public Text weapon;

    public void LoadData(UnitDetails u)
    {
        details = u;

        fullName.text = u.unitName + u.unitTitle;
        health.text = u.GetHealthTotal().ToString();
        loyalty.text = u.GetLoyaltyTotal().ToString();
        portrait.sprite = u.unitPortrait;
        armor.text = u.unitArmor;
        weapon.text = u.unitWeapon;
    }
}
