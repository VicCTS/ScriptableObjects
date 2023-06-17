using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItem[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;

    public ScriptableItem[] shields;
    public Text[] shieldsNames;
    public Image[] shieldsSprites;

    public ScriptableItem[] typeItem;
    public Text[] typeNames;
    public Image[] typeSprites;

    void Awake()
    {
        instance  = this;
    }

    public void AddItem(ScriptableItem item)
    {
        /*if(item.itemType == ScriptableItem.ItemType.Weapon)
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = item;
                    weaponsNames[i].text = item.itemName;
                    weaponsSprites[i].sprite = item.itemSprite;

                    return;
                }
            }
        }*/

        
        /*for (int i = 0; i < weapons.Length; i++)
        {
            if(item.itemType == ScriptableItem.ItemType.Weapon)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = item;
                    weaponsNames[i].text = item.itemName;
                    weaponsSprites[i].sprite = item.itemSprite;

                    return;
                }
            }
            else
            {
                if(shields[i] == null)
                {
                    shields[i] = item;
                    shieldsNames[i].text = item.itemName;
                    shieldsSprites[i].sprite = item.itemSprite;

                    return;
                }
            }
        }*/

        
    }
}
