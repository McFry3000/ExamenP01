
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
   
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            InventoryItem InventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
            InventoryItem.parentAfterDrag = transform;
        }
    }
}
