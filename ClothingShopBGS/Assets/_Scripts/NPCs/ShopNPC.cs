using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNPC : NPC
{
    [SerializeField] new ShopNPCSO _NPCDataSO;
    public InventorySO GetInventory() { return _NPCDataSO._ThisInventory; }
    public void OpenShop() 
    {
        //UIController.Instance.OpenShop(this);
        InventoryController.Instance.LoadShopInventory(this);
    }
    public void CloseShop() 
    {
        // Close Shop code
        DialogueController.Instance.StartSetOfDialogues(_NPCDataSO._CloseShopDialogues); ;
    }
    public int GetStockOfItem(ItemSO item) 
    {
    //For this task we wont handle the exception of the item whose stock is being asked for not being on the inventory of the npc.    
        return _NPCDataSO._ThisInventory._ItemsWithStock[item];
                
    }
}
 