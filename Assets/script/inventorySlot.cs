using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class inventorySlot : MonoBehaviour, IDropHandler
{
   /* public void OnDrag(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        draggableItem draggable = dropped.GetComponent<draggableItem>();
        draggable.parentAfterDrag = transform;
    }*/

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        draggableItem draggable = dropped.GetComponent<draggableItem>();
        if (draggable != null)
        {
            draggable.parentAfterDrag = transform;
        }
    }
}
