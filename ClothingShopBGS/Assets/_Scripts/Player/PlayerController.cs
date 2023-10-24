using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement _ThisPlayerMovement;
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