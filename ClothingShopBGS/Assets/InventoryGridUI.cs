using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryGridUI : MonoBehaviour
{
    [SerializeField] GameObject _ItemUIPrefab; //Only using one prefab for the Weareable Items. Would do a separate prefab for normal items.

   
    public void LoadInventory(InventorySO inventory) 
    {
        foreach (var item in inventory._ItemsWithStock)
        {
            GameObject newItem = Instantiate(_ItemUIPrefab, this.transform);            
            WeareableItemUI thisWeareableItemUI = newItem.GetComponent<WeareableItemUI>();
            thisWeareableItemUI.SetItem((WearableItemSO) item.Key); 
            //Simply casting this as Weareable item since the stock script does accept normal items, but for
            //this task I'm not making the separate normal item UI prefab and ItemUI.cs script.

        }
    }
}
