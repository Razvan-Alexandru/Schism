using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnMouseDown()
    {
        // Trigger collection logic
        Collect();
    }

    void OnMouseOver()
    {
        UIManager.Instance.ShowInteraction(gameObject.tag);
    }

    void OnMouseExit()
    {
        UIManager.Instance.RemoveInteraction();
    }


    void Collect()
    {
        InventoryManager.Instance.AddToInventory(gameObject.tag); 
        Destroy(gameObject);
    }
}
