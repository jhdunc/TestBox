using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Crafting Recipe", menuName = "Inventory System/Crafting/Recipe")]
public class CraftClass : ScriptableObject
{
    [Header("Crafting Recipe")]
    public InventoryObject inventory;
    public InventorySlot[] inputItems;
    public InventorySlot outputItem;

    public bool CanCraft(InventoryObject inventory)
    {
        for (int i = 0; i < inputItems.Length; i++)
        {
            if (!inventory.Contains(inputItems[i].GetItem(), inputItems[i].GetAmount()))
            {
                return false;
                
            }
        }
        return true;
    }
    public void Craft(InventoryObject inventory)
    {
        //remove the input items from inventory
        for (int i = 0; i < inputItems.Length; i++)
        {
            inventory.RemoveItems(inputItems[i].GetItem(), inputItems[i].GetAmount());

        }
        //add output item to inventory
        inventory.AddItem(outputItem.GetItem(), outputItem.GetAmount());
    }

}