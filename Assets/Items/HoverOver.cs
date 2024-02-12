using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

        public GameObject HoverPanel1;


    public void OnPointerEnter(PointerEventData eventData)
        {
            HoverPanel1.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            HoverPanel1.SetActive(false);
        }
    }



