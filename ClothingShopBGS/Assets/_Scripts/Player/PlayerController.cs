using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement _ThisPlayerMovement;
    [SerializeField] PlayerInteraction _ThisPlayerInteraction;
    private void Awake()
    {
        GameplayEvents.OnOpenDialogue.AddListener(DisableMovement);        
        GameplayEvents.OnClosedDialogue.AddListener(EnableMovement);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) { _ThisPlayerInteraction.Interact(); }
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            UIController.Instance.OpenCanvas(UIScreen.Inventory);
        }
    }
    private void DisableMovement() 
    {
        _ThisPlayerMovement.enabled = false;
    }
    private void EnableMovement() 
    {
        _ThisPlayerMovement.enabled = true;
    }
    public PlayerDirections GetDirection() 
    {
        return _ThisPlayerMovement.GetCurrentDirection();
    }
    public Vector2 GetVectorDirection() 
    {
        switch (_ThisPlayerMovement.GetCurrentDirection()) 
        {
            case PlayerDirections.Left:
                return Vector2.left;           
            case PlayerDirections.Right:
                return Vector2.right;            
            case PlayerDirections.Up:
                return Vector2.up;            
            case PlayerDirections.Down:
                return Vector2.down;            
        }
        return Vector2.zero;
    }
}
public enum PlayerDirections { Left, Right, Up, Down }