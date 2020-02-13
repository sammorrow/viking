using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Sprite inactive;
    public Sprite active;
    public Sprite hover;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = inactive;
    }

    private void OnMouseDown()
    {
        this.GetComponent<SpriteRenderer>().sprite = active;
    }

    private void OnMouseEnter()
    {
        this.GetComponent<SpriteRenderer>().sprite = hover;
    }

    private void OnMouseExit()
    {
        this.GetComponent<SpriteRenderer>().sprite = inactive;
    }

    private void OnMouseUp()
    {
        this.GetComponent<SpriteRenderer>().sprite = inactive;
    }
}
