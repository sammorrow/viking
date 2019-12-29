using UnityEngine;
using System.Collections;

public class SendUnitDetails : MonoBehaviour
{
    public UnitDetails unit;
    private UnitCardImpl unitCard;

    private void Start()
    {
        unitCard = GameObject.FindWithTag("theonlyunitcard").GetComponent<UnitCardImpl>();
    }


    public void SendData(UnitDetails u)
    {
        unitCard.LoadData(u, transform.position.x, transform.position.y);
    }

    void OnMouseDown()
    {
        Debug.Log("Sprite Clicked");
        this.SendData(unit);
    }
}
