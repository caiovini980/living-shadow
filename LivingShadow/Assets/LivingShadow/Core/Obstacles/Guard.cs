using Core.EventSystem;
using System;
using UnityEngine;

namespace Core.Obstacles
{
    public class Guard : ObstacleBase
    {
        [Range(0, 100)]
        [Tooltip("Speed this guard should turn around.")]
        [SerializeField] private float _turnSpeed;

        [Space]
        [SerializeField] private LightBehaviour _lightBehaviour;

        private Transform _targetTransform;
        private bool _isFocusingTarget = false;

        public override void SetupObstacle()
        {
            if (_initialPosition == Vector2.zero)
            {
                Debug.LogWarning($"Initial position for {name} is {_initialPosition}");
            }

            EventController.OnLightTouched += DetectObject;
        }

        public override void UpdateObstacle()
        {
            if (!_isFocusingTarget && _lightBehaviour.detectedObjectType == DetectableObjectType.NONE)
            {
                gameObject.transform.Rotate(0, 0, _turnSpeed / 10);
                return;
            }
        }

        public override void ClearObstacle()
        {
        }

        private void DetectObject(Transform detectedTransform)
        {
            _isFocusingTarget = true;
            FollowTarget(detectedTransform);
        }

        private void FollowTarget(Transform target)
        {
            transform.LookAt(target);
        }

        private void StopFollowTargets()
        {
            _isFocusingTarget = false;
        }
    }
}

