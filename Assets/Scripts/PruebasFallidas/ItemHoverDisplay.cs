using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class ItemHoverDisplay : MonoBehaviour
{
    public TextMeshProUGUI itemNameText;
    public TextMeshProUGUI descriptionText;
    // Agrega otros elementos UI necesarios para mostrar los atributos

    public List<Item> itemsToShowHover;

    public void ShowHoverData(ItemHoverData hoverData)
    {
        itemNameText.text = hoverData.itemName;
        descriptionText.text = hoverData.description;
        // Configura otros elementos UI con los atributos del ItemHoverData
    }


    public void HideHoverData()
    {
        itemNameText.text = "";
        descriptionText.text = "";
        // Oculta los elementos UI
    }
}

