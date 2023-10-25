using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance;
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
        UIController.Instance.OpenShop(ShopData.GetInventory());
    }
}
