using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItem item;

    SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

        sRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        InventoryManager.instance.AddItem(item);

        Destroy(gameObject);
    }
}
