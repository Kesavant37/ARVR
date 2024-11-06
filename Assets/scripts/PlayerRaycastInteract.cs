using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycastInteract : MonoBehaviour
{
    [SerializeField] private float raycastRange = 5f;
    [SerializeField] private LayerMask interactableLayer;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Left mouse button
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, raycastRange, interactableLayer))
            {
                var interactable = hit.collider.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }
}

