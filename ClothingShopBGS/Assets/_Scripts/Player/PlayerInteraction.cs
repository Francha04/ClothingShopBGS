using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] PlayerController _Controller;
    [SerializeField] float _InteractionDistance;
    Interactable currentTarget;
    RaycastHit2D hit;
    private void Update()
    {
        hit = Physics2D.Raycast(this.transform.position, _Controller.GetVectorDirection(), _InteractionDistance);        
        if (hit.collider == null )
        {
            return;
        }          
        if (hit.collider.TryGetComponent<Interactable>(out currentTarget))
        {
            print("New target: " + currentTarget);
        }

        if (Input.GetKeyDown(KeyCode.E)) 
        {
            currentTarget.StartInteraction();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(this.transform.position, _Controller.GetVectorDirection().normalized * _InteractionDistance);
    }
}