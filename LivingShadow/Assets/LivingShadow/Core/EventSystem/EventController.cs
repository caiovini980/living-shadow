using UnityEngine;

namespace Core.EventSystem
{
    public class EventController : MonoBehaviour
    {
        public delegate void LightTouchedAction();
        public static event LightTouchedAction OnLightTouched;
        public void TriggerOnLightTouchedEvent()
        {
            if (OnLightTouched != null)
            {
                OnLightTouched();
                return;
            }

            Debug.LogError("OnLightTouched is null");
        }


        public delegate void RestartLevelAction();
        public static event RestartLevelAction OnRestartLevel;
        public void TriggerRestartLevelEvent()
        {
            if (OnRestartLevel != null)
            {
                OnRestartLevel();
                return;
            }

            Debug.LogError("OnRestartLevel is null");
        }
    }
}

