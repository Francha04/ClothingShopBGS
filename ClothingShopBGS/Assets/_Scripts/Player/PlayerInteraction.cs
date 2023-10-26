using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] PlayerController _Controller;
    [SerializeField] float _InteractionDistance;
    public ShopNPC currentTarget = null;
    [SerializeField] LayerMask layer;
    RaycastHit2D hit;   
    private void Update()
    {
        hit = Physics2D.Raycast(this.transform.position, _Controller.GetVectorDirection(), _InteractionDistance, layer);  
        if (hit.collider == null )
        {
            currentTarget = null;
            return;
        }          
        if (hit.collider.TryGetComponent<ShopNPC>(out currentTarget))
        {
            print("New target: " + currentTarget);
        }

    }
    public void Interact() 
    {
        if (currentTarget == null) { return; } 
        currentTarget.StartInteraction();
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(this.transform.position, _Controller.GetVectorDirection().normalized * _InteractionDistance);
    }
}