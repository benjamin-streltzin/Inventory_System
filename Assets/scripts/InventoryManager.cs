using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public InventorySlots[] inventorySlots;
    public GameObject inventoryItemPrefab;
    public void AddItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlots slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return;
            }
        }
    }

    private void Awake()
    {
        instance = this;
    }


    void SpawnNewItem(Item item, InventorySlots slot)
        {
            GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
            InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
            inventoryItem.InizializeItem(item);
        }




    }




