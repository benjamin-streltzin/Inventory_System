using UnityEngine;
using static UnityEditor.Progress;

public class pickUpSystem : MonoBehaviour
{

    
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.TryGetComponent(out Loot loot))
        {
            InventoryManager.instance.AddItem(loot.item);
            Destroy(loot.gameObject);
        }

    }
}




















