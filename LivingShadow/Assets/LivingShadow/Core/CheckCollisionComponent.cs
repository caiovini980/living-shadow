using UnityEngine;

public class CheckCollisionComponent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"Triggering component on {other.name}");
    }
}
