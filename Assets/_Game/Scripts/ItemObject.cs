using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{/*
    public InventoryItemData referenceItem;

    public void OnHandlePickupItem()
    {
        InventorySystem.current.Add(referenceItem);
        Destroy(gameObject);
    }

    void Update()
    {
        if(!useLookAt)
        {
            _targetPosition = _parent.position + _parent.forward * new Vector3(0f, 2f, 0f);
        }

        _lookAtTarget.transform.position = Vector3.Lerp(_lookAtTarget.transform.position, _targetPosition, Time.deltaTime * lookSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_lookAtTarget != null && _lookAtTarget.TryGetComponent<ItemObject>(out ItemObject Item))
            {
                itemController.SetTargetPosition(Item.transform);
                itemController.Pickup();
            }
        }
    }

    public void OnTriggerEnder(Collider collider)
    {
        if(collicer.transform.GetComponent<PointOfInterest>())
        {
            _targetPosition = collider.transform.position;
            useLookAt = true;
        }
    }
    public void OnTriggerExit(Collider collider)
    {
        useLookAt = false;
    }*/
}
