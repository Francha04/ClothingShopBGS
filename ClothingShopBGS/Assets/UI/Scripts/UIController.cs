using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script is adapted from another project.
public class UIController : MonoBehaviour
{
    public static UIController Instance;

    [SerializeField] private Canvas _MainCanvas;
    [SerializeField] private Canvas _InventoryCanvas;
    [SerializeField] private Canvas _DialogueCanvas;
    Dictionary<UIScreen, Canvas> canvasByType = new Dictionary<UIScreen, Canvas>();
    private void Awake()
    {
        if (Instance != null) { Destroy(this); }
        else
        {
            Instance = this;
        }
        canvasByType.Clear();
        canvasByType.Add(UIScreen.Main, _MainCanvas);
        canvasByType.Add(UIScreen.Inventory, _InventoryCanvas);
        canvasByType.Add(UIScreen.Dialogue, _DialogueCanvas);
        //GameplayEvents.OnShopOpen.AddListener(OpenShop); For now will not be used.
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
//When adding a new screen, add it to the enum and to the dictionary.