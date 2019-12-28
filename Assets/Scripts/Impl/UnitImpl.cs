using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitImpl : MonoBehaviour
{
    public UnitDetails details;

    public Text fullName;
    public Image portrait;
    public Text health;
    public Text loyalty;

    // Start is called before the first frame update
    void Start()
    {
        LoadData(details);
    }

    public void LoadData(UnitDetails u)
    {
        details = u;

        fullName.text = u.unitName + u.unitTitle;
        health.text = u.GetHealthTotal().ToString();
        loyalty.text = u.GetLoyaltyTotal().ToString();
        portrait.sprite = u.unitPortrait;
    }
}
