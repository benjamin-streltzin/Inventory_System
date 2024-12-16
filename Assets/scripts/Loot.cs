using UnityEngine;

public class Loot : MonoBehaviour
{
    public SpriteRenderer sr;

    public Item item;







    public void Awake()
    {
        // Ensure the SpriteRenderer is assigned
        if (sr == null)
        {
            sr = GetComponent<SpriteRenderer>();  // Automatically get the SpriteRenderer if not set
        }

        // If the item is assigned, set the sprite
        if (item != null && sr != null)
        {
            sr.sprite = item.image;  // Set the sprite of the loot based on the item
        }
        else
        {
            Debug.LogWarning("Loot item or SpriteRenderer is not assigned.");
        }
    }



    }


