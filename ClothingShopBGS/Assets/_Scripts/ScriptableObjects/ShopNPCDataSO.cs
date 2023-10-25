using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
[CreateAssetMenu(fileName = "ShopNPCDataSO", menuName = "ScriptableObjects/ShopNPCData", order = 6)]

public class ShopNPCDataSO : ScriptableObject
{
    public InventorySO _ThisInventory;
    public List<DialogueSO> _CloseShopDialogues;
}
