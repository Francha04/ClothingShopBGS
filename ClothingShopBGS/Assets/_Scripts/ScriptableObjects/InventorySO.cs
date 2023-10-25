using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "InventorySO", menuName = "ScriptableObjects/NPCInventory", order = 1)]
public class InventorySO : ScriptableObject
{
    public List<ItemWithStockSO> _ItemsWithStock = new List<ItemWithStockSO>();
    
}
