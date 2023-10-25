using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// I will not make the parent class ItemUI due to time constraints, since all the items in the task will be weareable.
public class WeareableItemUI : MonoBehaviour
{
    public WearableItemSO _CurrentItem { get; set; }

    [SerializeField] Button _ThisButton;
    [SerializeField] Image _ThisSprite;
    [SerializeField] GameObject _EquippedVisuals;
    [SerializeField] GameObject _OutOfStockVisuals;
    [SerializeField] TextMeshProUGUI _StockText;
    public InventoryController _InventoryController;
    private void Awake()
    {
        _ThisButton.onClick.AddListener(OnButtonClick);
    }
    private void OnButtonClick() 
    {
        InventoryController.Instance.OnClick(_CurrentItem);
    }
    public void SetItem(WearableItemSO item) 
    {
        _CurrentItem = item;
        _ThisSprite.sprite = item._ItemSprite;
        SetItemEquipped(item.isEquipped);
    }
    public void SetItemEquipped(bool equipped) 
    {
        _EquippedVisuals.SetActive(equipped);
    }
    public void SetStock(int stock)
    {
        if (stock < 0) { print("Negative stock on item: " + this.gameObject.name); return; }       
        if (stock == -1) {
            _StockText.text = "";
            _OutOfStockVisuals.SetActive(false);
            return;
        }
        _StockText.text = stock.ToString();
        if (stock == 0) { _OutOfStockVisuals.SetActive(true); }
        else {            
            _OutOfStockVisuals.SetActive(false);
        }
        
        
    }

}
