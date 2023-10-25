using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    [SerializeField] Dictionary<UIScreen, Canvas> canvasByType = new Dictionary<UIScreen, Canvas>();
    private void Awake()
    {
        if (Instance != null) { Destroy(this); }
        else
        {
            Instance = this;
        }
        //GameplayEvents.OnShopOpen.AddListener(OpenShop);
    }
    public void OpenShop(InventorySO inventoryInfo) 
    {
        OpenCanvas(UIScreen.Shop);
    }
    public void OpenCanvas(UIScreen ScreenToOpen) 
    {
        foreach (UIScreen canv in canvasByType.Keys)
        {
            if (ScreenToOpen == canv) { canvasByType[ScreenToOpen].enabled = true; }
            else if (canv != UIScreen.Main)
            {
                canvasByType[canv].enabled = false;
            }
        }
    }
}
public enum UIScreen 
{
    Main,
    Inventory,
    Dialogue,
    Shop
}
