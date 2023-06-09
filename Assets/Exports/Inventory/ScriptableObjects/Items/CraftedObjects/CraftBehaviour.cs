using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftBehaviour : MonoBehaviour
{
    [SerializeField] private List<CraftClass> craftingRecipes = new List<CraftClass>();
    public InventoryObject inventory;/*
    public InventoryObject craftInventory;*/
/*    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Craft(craftingRecipes[0]);
        }
    }*/
    public void MakeOne()
    {
        Craft(craftingRecipes[0]);
    }
    public void Craft(CraftClass recipe)
    {
        if (recipe.CanCraft(inventory))
            recipe.Craft(inventory);
        else
            //show error
            Debug.Log("Can't craft that item");
    }

}
