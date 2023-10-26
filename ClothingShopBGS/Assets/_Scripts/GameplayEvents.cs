using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameplayEvents : MonoBehaviour
{
    private static GameplayEvents instance;
    private readonly UnityEvent openDialogue = new UnityEvent();
    private readonly UnityEvent<ShopNPC> openShop = new UnityEvent<ShopNPC>();
    private readonly UnityEvent closedShop = new UnityEvent();
    private readonly UnityEvent closedDialogue = new UnityEvent();
    public static UnityEvent<ShopNPC> OnShopOpen => instance.openShop;
    public static UnityEvent OnOpenDialogue => instance.openDialogue;
    public static UnityEvent OnClosedDialogue => instance.closedDialogue;
    public static UnityEvent OnClosedShop => instance.closedShop;

    private void Awake()
    {
        instance = this;
    }
}
