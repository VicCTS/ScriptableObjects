using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItem[] weapons;

    public Text[] weaponsNames;
    public Text[] weaponsDamage;
    public Image[] weaponsSprites;
    //public InventorySlot[] weaponSlot;

    /*public ScriptableItem[] shields;
    public Text[] shieldsNames;
    public Image[] shieldsSprites;*/

    void Awake()
    {
        instance  = this;
    }

    public void AddItem(ScriptableItem item)
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

        /*if(item.itemType == ScriptableItem.ItemType.Weapon)
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = item;
                    weaponsNames[i].text = item.itemName;
                    weaponsSprites[i].sprite = item.itemSprite;

                    weaponSlot[i].slotItem = item;
                    weaponSlot[i].slotNumber = i;

                    return;
                }
            }
        }*/
        /*else if(item.itemType == ScriptableItem.ItemType.Shield)
        {
            for (int i = 0; i < shields.Length; i++)
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
