using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Raw Material Object", menuName = "Inventory System/Items/Raw Material")]
public class RawObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.RawMaterial;
    }
}
