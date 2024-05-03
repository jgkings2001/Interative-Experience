using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;

    private ObjectGrabbable objectGrabbable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabbable == null)
            {
                float pickUpDistance = 2f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance = 2f, pickUpLayerMask)) ;
                //Debug.Log(raycastHit.transform);
                if (raycastHit.transform.TryGetComponent(out objectGrabbable)) {
                    objectGrabbable.Grab(objectGrabPointTransform);
                    //Debug.Log(objectGrabbable);
                }
            }
        } else {
            objectGrabbable.Drop();
            objectGrabbable = null;
        }
    }
}
