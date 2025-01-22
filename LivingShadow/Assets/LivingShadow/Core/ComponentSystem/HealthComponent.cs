using UnityEngine;
using Core.EventSystem;
using System;

[RequireComponent(typeof(ComponentController))]
public class HealthComponent : MonoBehaviour, IShadowComponent
{
    [SerializeField] private uint _maxHealth = 1;
    [SerializeField] private uint _damage = 1;

    private EventController _eventController;

    private uint _currentHealth = 1;
     
    public void StartComponent(EventController eventController)
    {
        _eventController = eventController;
        _currentHealth = _maxHealth;

        SetupEvents();
    }

    public void UpdateComponent()
    {
    }

    public void ClearComponent()
    {
        ClearEvents();
    }

    private void UpdateHealth()
    {
        Debug.Log("Changing health");
        _currentHealth -= _damage;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            _eventController.TriggerRestartLevelEvent();
        }

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }

    public void SetupEvents()
    {
        EventController.OnLightTouched += UpdateHealth;
    }

    public void ClearEvents()
    {
        EventController.OnLightTouched -= UpdateHealth;
    }
}
