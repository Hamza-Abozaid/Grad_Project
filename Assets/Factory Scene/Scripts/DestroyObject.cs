using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object we collided with has the tag "Player"
        if (collision.gameObject.CompareTag("Machine"))
        {
            // Destroy this game object
            Destroy(gameObject);
            MiddleMan.Instance.Spawner.active_objects.Remove(gameObject);
        }
    }
}
