using Core.EventSystem;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ComponentController : MonoBehaviour
{
    [SerializeField] private EventController _eventController;

    private IShadowComponent[] _componentList;

    private void Awake()
    {
        _componentList = GetComponents<IShadowComponent>();
    }

    void Update()
    {
        foreach (IShadowComponent component in _componentList)
        {
            component.UpdateComponent();
        }
    }
    private void OnEnable()
    {
        foreach (IShadowComponent component in _componentList)
        {
            component.StartComponent(_eventController);
        }
    }

    private void OnDisable()
    {
        foreach (IShadowComponent component in _componentList)
        {
            component.ClearComponent();
        }
    }
}
