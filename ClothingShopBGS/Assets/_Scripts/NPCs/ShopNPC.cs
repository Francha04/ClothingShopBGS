using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNPC : NPC
{
    [SerializeField] new ShopNPCSO _NPCDataSO;
    public InventorySO GetInventory() { return _NPCDataSO._ThisInventory; }
    public void OpenShop() 
    {
        UIController.Instance.OpenCanvas(UIScreen.Shop);
    }
    public void CloseShop() 
    {
        // Close Shop code
        DialogueController.Instance.StartSetOfDialogues(_NPCDataSO._CloseShopDialogues); ;
    }
}
 