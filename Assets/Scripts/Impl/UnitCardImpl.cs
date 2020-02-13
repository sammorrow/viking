using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitCardImpl : MonoBehaviour
{
    private UnitDetails details;

    public Text fullName;
    public Image portrait;
    public HealthSpriteController healthController;
    public Text loyalty;
    public Text armor;
    public Text weapon;

    private bool isVisible;

    public void LoadData(UnitDetails u, float x, float y)
    {
        if (details != u)
        {
            isVisible = true;
        }

        ToggleVisibility();

        details = u;

        fullName.text = u.GetFullName();
        loyalty.text = u.GetLoyaltyTotal().ToString();
        portrait.sprite = u.unitPortrait;
        armor.text = u.unitArmor;
        weapon.text = u.unitWeapon;

        this.healthController.SetHealth(u.healthCurrent, u.GetHealthTotal());


        transform.position = new Vector3(x + 1, y + 3, transform.position.z);
    }

    private void ToggleVisibility()
    {
        Component[] children = gameObject.GetComponentsInChildren<Component>();
        
        foreach (Component child in children)
        {
            if (child.GetType() == typeof(Image)){
                Image childImg = (Image) child;
                childImg.enabled = isVisible;
            }

            if (child.GetType() == typeof(Text))
            {
                Text childTxt = (Text) child;
                childTxt.enabled = isVisible;
            }
        }
        isVisible = !isVisible;
    }
}
