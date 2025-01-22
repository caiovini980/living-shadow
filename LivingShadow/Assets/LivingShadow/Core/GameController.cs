using Core;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private ManagerBase[] _managers;

    private void Awake()
    {
        _managers = GetComponents<ManagerBase>();    
    }

    private void Start()
    {
        foreach (ManagerBase manager in _managers)
        {
            manager.SetupManager();
        }

        Debug.Log("Managers created!");
    }

    private void Update()
    {
        foreach (ManagerBase manager in _managers)
        {
            manager.UpdateManager();
        }
    }

    private void OnDisable()
    {
        foreach (ManagerBase manager in _managers)
        {
            manager.ClearManager();
        }

        Debug.Log("Managers cleared!");
    }
}
