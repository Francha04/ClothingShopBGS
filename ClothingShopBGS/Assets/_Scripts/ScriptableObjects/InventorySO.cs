using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NPCInventory", menuName = "ScriptableObjects/NPCInventory", order = 6)]
public class InventorySO : MonoBehaviour
{
    public Dictionary<ItemSO, int> _ItemsWithStock { get; set; } = new System.Collections.Generic.Dictionary<ItemSO, int>(); 
    // A stock of -1 represents an item with an infinite amount of copies.
}
