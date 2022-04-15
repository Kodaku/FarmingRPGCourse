using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();

        if(item != null)
        {
            // Get ItemDetails
            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(item.ItemCode);

            print(itemDetails.itemDescription);
        }
    }
}
