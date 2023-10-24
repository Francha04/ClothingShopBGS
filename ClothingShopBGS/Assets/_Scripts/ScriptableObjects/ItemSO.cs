using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/InventoryItem", order = 3)]
public class ItemSO : MonoBehaviour
{
    [SerializeField] string _ItemViewName;
    [SerializeField] Sprite _ItemUIIcon;
    [SerializeField] float _ItemPrice; //Whislt 0 equals free, -1 means that it has no price thus cannot be sold nor bought.
}
