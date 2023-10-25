using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/InventoryItem", order = 3)]
public class ItemSO : MonoBehaviour
{
    public string _ItemViewName { get; set; } = "NullItem";
    public Sprite _ItemSprite { get; set; }
    public float _ItemPrice { get; set; } = -1; //Whislt 0 equals free, -1 means that it has no price thus cannot be sold nor bought.
}
