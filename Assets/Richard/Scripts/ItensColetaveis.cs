using UnityEngine;

public class ItensColetáveis : MonoBehaviour
{
    public string itemName;
    public int itemId;
    public string description;
    public Sprite icon;
    public int value;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Inventory inventory = other.GetComponent<Inventory>();
            if (inventory != null)
            {
                inventory.AddItem(itemName, itemId, description, icon, value);
                Destroy(gameObject); // remove o item da cena
            }
        }
    }
}