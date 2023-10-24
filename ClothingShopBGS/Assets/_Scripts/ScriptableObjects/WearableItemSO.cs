using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/WeareableItem", order = 4)]
public class WearableItemSO : ItemSO
{
    [SerializeField] Sprite _UpSprite;
    [SerializeField] Sprite _RightSprite;
    [SerializeField] Sprite _DownSprite;
    [SerializeField] Sprite _LeftSprite;
    public TypeOfWeareable _TypeOfClothes { get; set; }
    public bool isEquipped { get; set; } = false;

}
public enum TypeOfWeareable 
{
    Hat,
    MainBodyClothes
}
