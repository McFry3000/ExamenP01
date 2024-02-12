using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ItemHoverDisplay hoverDisplay;

    public ItemHoverData hoverData;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverDisplay != null && hoverData != null)
        {
            hoverDisplay.ShowHoverData(hoverData);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (hoverDisplay != null)
        {
            hoverDisplay.HideHoverData();
        }
    }

    public void SetHoverData(ItemHoverData data)
    {
        hoverData = data;
    }
}


