using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNPC : NPC
{
    [SerializeField] InventorySO _ThisInventory;
    [SerializeField] List<DialogueSO> _CloseShopDialogues;
    public InventorySO GetInventory() { return _ThisInventory; }
    public void OpenShop() 
    {
    }
    public void CloseShop() 
    {
        // Close Shop code
        DialogueController.Instance.StartSetOfDialogues(_CloseShopDialogues);
    }
}
