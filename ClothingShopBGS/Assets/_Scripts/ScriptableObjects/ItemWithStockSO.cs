using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemWithStockSO", menuName = "ScriptableObjects/NPCInventory", order = 1)]
public class ItemWithStockSO : ScriptableObject
{
    public ItemSO _Item;
    public int _Stock;
}
// A stock of -1 represents an item with an infinite amount of copies.