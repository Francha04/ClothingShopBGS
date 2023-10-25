using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// I will not make the parent class ItemUI due to time constraints, since all the items in the task will be weareable.
public class WeareableItemUI : MonoBehaviour
{
    public WearableItemSO _CurrentItem { get; set; }

    [SerializeField] Button _ThisButton;
    [SerializeField] Image _ThisSprite;
    [SerializeField] GameObject _EquippedVisuals;
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

}
