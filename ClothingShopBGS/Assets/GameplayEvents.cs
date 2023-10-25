using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameplayEvents : MonoBehaviour
{
    private static GameplayEvents instance;

    private readonly UnityEvent<ShopNPC> openShop = new UnityEvent<ShopNPC>();    
    public static UnityEvent<ShopNPC> OnShopOpen => instance.openShop;

    private void Awake()
    {
        instance = this;
    }
}
