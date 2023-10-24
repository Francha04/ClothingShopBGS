using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNPCSO : NPCSO
{
    public InventorySO _ThisInventory { get; set; }
    public List<DialogueSO> _CloseShopDialogues { get; set; } = new List<DialogueSO>();
}
