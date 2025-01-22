using UnityEngine;
using Core;
using Core.Obstacles;
using System.Collections.Generic;

public class ObstacleManager : ManagerBase
{
    [SerializeField] private GameObject[] _obstaclesOnLevel;

    private List<ObstacleBase> _obstacleSpawned = new List<ObstacleBase>();

    public override void SetupManager()
    {
        foreach (GameObject obstacleObject in _obstaclesOnLevel)
        {
            ObstacleBase obstacle = obstacleObject.GetComponent<ObstacleBase>();

            if (obstacle == null)
            {
                continue;
            }

            if (!_obstacleSpawned.Contains(obstacle))
            {
                Debug.Log("Instantiating new obstacle");
                obstacle = Instantiate(obstacleObject).GetComponent<ObstacleBase>();

                _obstacleSpawned.Add(obstacle);
            }

            obstacle.SetupObstacle();
            obstacle.GoToOriginalPosition();
        }
    }

    public override void UpdateManager()
    {
        foreach (ObstacleBase obstacle in _obstacleSpawned)
        {
            obstacle.UpdateObstacle();
        }
    }

    public override void ClearManager()
    {
        foreach (ObstacleBase obstacle in _obstacleSpawned)
        {
            obstacle.ClearObstacle();
        }
    }
}
