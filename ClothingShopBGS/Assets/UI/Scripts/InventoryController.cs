using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance;
    public ShopNPC _CurrentNPC = null;
    [SerializeField] InventoryGridUI _ThisGridUI;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else Instance = this;
    }
    public void LoadShopInventory(ShopNPC ShopData) 
    {
        _CurrentNPC = ShopData;
        UIController.Instance.OpenCanvas(UIScreen.Inventory);
        _ThisGridUI.LoadInventory(ShopData.GetInventory());
    }
    public void OnClick(WearableItemSO itemClicked) 
    {
        int stock = _CurrentNPC.GetStockOfItem(itemClicked);           
        
    }
}
