using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvBehavior : MonoBehaviour
{

    public InventoryObject inventory;
    private ShaderVariantCollection floatText;
    


    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            item.nearPlayer = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            item.nearPlayer = false;
        }
    }
    
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            inventory.Load();
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Items.Clear();
    }
}
