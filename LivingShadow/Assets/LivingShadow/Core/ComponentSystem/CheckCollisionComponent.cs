using Core.EventSystem;
using UnityEngine;

[RequireComponent(typeof(ComponentController))]
public class CheckCollisionComponent : MonoBehaviour, IShadowComponent
{
    private EventController _eventController;
    public void StartComponent(EventController eventController)
    {
        _eventController = eventController;
    }

    public void SetupEvents()
    {
    }

    public void UpdateComponent()
    {
    }

    public void ClearComponent()
    {
    }

    public void ClearEvents()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3) // Player
        {
            Debug.Log("Triggering component on Player");
            _eventController.TriggerOnLightTouchedEvent();
            
        }
    }
}
