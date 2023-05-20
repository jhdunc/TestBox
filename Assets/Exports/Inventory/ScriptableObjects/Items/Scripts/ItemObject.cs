using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    RawMaterial,
    Crafted,
    Consumable
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject iconPrefab;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;
}
