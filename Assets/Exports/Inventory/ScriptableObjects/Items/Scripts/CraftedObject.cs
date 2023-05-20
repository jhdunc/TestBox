using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Crafted Object", menuName = "Inventory System/Items/Crafted")]
public class CraftedObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Crafted;
    }
}
