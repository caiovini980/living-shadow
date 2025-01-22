using UnityEngine;

namespace Core.Obstacles
{
    public abstract class ObstacleBase : MonoBehaviour
    {
        [SerializeField] protected Vector2 _initialPosition = Vector2.zero;

        public abstract void SetupObstacle();
        public virtual void UpdateObstacle() { }
        public abstract void ClearObstacle();

        public void GoToOriginalPosition()
        {
            transform.position = _initialPosition;
        }

        public Vector2 GetInitialPosition()
        {
            return _initialPosition;
        }
    }
}