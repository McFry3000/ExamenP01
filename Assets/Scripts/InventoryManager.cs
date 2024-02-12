using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int maxStackItem = 6;
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    public bool AddItem (Item item)
    {
        //Stackeando en slots
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem iteminSlot = slot.GetComponentInChildren<InventoryItem>();
            if (iteminSlot != null && iteminSlot.item == item && iteminSlot.count < maxStackItem && iteminSlot.item.stackable == true)
            {
                iteminSlot.count++;
                iteminSlot.Resetcount();
                return true;
            }
        }


        // Encontrar slot vacio
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem iteminSlot = slot.GetComponentInChildren<InventoryItem>();
            if (iteminSlot == null)
            {
                SpawnNewItem(item, slot);
                return true;
            }
        }
        return false;
    }

    void SpawnNewItem(Item item, InventorySlot slot)
    {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);

    }
}
 