using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpriteController : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public GameObject fullHeart;
    public GameObject emptyHeart;

    private void Start()
    {
        this.SetHealth(currentHealth, maxHealth);
    }

    public void SetHealth(int curr, int max)
    {
        this.Clear();
        for (int i = 0; i < curr; i++)
        {
            Instantiate(fullHeart, this.transform.position, Quaternion.identity, this.transform);

        }

        for (int i = 0; i < (max - curr); i++)
        {
            Instantiate(emptyHeart, this.transform.position, Quaternion.identity, this.transform);
        }
    }

    void Clear()
    {
        foreach (Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
