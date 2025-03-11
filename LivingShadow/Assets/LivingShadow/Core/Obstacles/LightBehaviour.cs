using Core.EventSystem;
using UnityEngine;

namespace Core.Obstacles
{
    public enum DetectableObjectType
    {
        NONE = -1,
        PLAYER = 0
        // ...
    }

    public class LightBehaviour : MonoBehaviour
    {
        private DetectableObjectType _detectedObjectType = DetectableObjectType.NONE;
        public DetectableObjectType detectedObjectType 
        { 
            get => _detectedObjectType; 
            private set => _detectedObjectType = value; 
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Hitting something");
            if (collision.gameObject.layer == 3)
            {
                Debug.Log("Light is hitting player");
                _detectedObjectType = DetectableObjectType.PLAYER;
                EventController.TriggerOnLightTouchedEvent(collision.transform);

                // make the parent follow the player
                // execute 
            }
        }
    }
}
