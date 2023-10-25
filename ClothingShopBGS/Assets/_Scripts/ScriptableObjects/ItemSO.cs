using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemSO", menuName = "ScriptableObjects/InventoryItem", order = 3)]

//If you are making a store, place these items inside ItemWithStockSO objects.
public class ItemSO : ScriptableObject
{
    public string _ItemViewName { get; set; } = "NullItem";
    public Sprite _ItemSprite { get; set; }
    public float _ItemPrice { get; set; } = -1; //Whislt 0 equals free, -1 means that it has no price thus cannot be sold nor bought.
}
