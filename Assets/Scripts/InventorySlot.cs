using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;
    public int slotNumber;

    public GameObject inspectionWindows;
    public Image inspectionImages;
    public Text inspectionDescriptions;
    public Button removeButton;

    /*public void RemoveItem()
    {
        if(slotItem.itemType == ScriptableItem.ItemType.Weapon)
        {
            if(InventoryManager.instance.weapons[slotNumber] != null)
            {
                InventoryManager.instance.weapons[slotNumber] = null;
                InventoryManager.instance.weaponsNames[slotNumber].text = "Empty";
                InventoryManager.instance.weaponsSprites[slotNumber].sprite = null;
            }
        }
        else
        {
            if(InventoryManager.instance.shields[slotNumber] != null)
            {
                InventoryManager.instance.shields[slotNumber] = null;
                InventoryManager.instance.shieldsNames[slotNumber].text = "Empty";
                InventoryManager.instance.shieldsSprites[slotNumber].sprite = null;
            }
        }

        slotItem = null;
        slotNumber = 0;

        removeButton.onClick.RemoveListener(RemoveItem);
        inspectionWindows.SetActive(false);
    }

    public void InspectItem()
    {
        if(slotItem != null)
        {
            removeButton.onClick.AddListener(RemoveItem);

            inspectionImages.sprite = slotItem.itemSprite;
            inspectionDescriptions.text = slotItem.itemName;

            inspectionWindows.SetActive(true);
        }
    }*/
}
