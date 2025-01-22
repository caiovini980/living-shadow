using UnityEngine;

namespace Core.Obstacles
{
    public class Guard : ObstacleBase
    {
        [Range(0, 100)]
        [Tooltip("Speed this guard should turn around.")]
        [SerializeField] private float _turnSpeed;

        public override void SetupObstacle()
        {
            if (_initialPosition == Vector2.zero)
            {
                Debug.LogWarning($"Initial position for {name} is {_initialPosition}");
            }
        }

        public override void UpdateObstacle()
        {
            gameObject.transform.Rotate(0, 0, _turnSpeed / 10);
        }

        public override void ClearObstacle()
        {
        }
    }
}

