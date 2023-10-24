using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNPC : NPC
{
    [SerializeField] InventorySO _ThisInventory;

    public InventorySO GetInventory() { return _ThisInventory; }
}
