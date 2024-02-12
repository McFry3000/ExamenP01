using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "New Item Hover Data", menuName = "Inventory/Item Hover Data")]
    public class ItemHoverData : ScriptableObject
    {
        public string itemName;
        public string description;
    public string type;
    public string rare;
    public string hab;
        // Agrega otros atributos que desees mostrar en el hover
    }

