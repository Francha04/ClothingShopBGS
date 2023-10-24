using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearableItemSO : ItemSO
{
    [SerializeField] Sprite _UpSprite;
    [SerializeField] Sprite _RightSprite;
    [SerializeField] Sprite _DownSprite;
    [SerializeField] Sprite _LeftSprite;
    public bool isEquipped { get; set; } = false;
}
