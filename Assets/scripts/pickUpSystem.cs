using UnityEngine;

public class pickUpSystem : MonoBehaviour
{

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.TryGetComponent(out PickUp pickup))
        {
            pickup.gameObject.SetActive(false);
        }

    }
}




















