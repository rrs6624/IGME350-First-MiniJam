using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has a specific name or tag
        if (collision.gameObject.CompareTag("Wallet"))
        {
            Debug.Log("Collided with Akai Saifu!");
        }
    }
}
