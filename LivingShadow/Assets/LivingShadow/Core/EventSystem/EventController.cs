using UnityEngine;

/*
 I'm not using this, I believe. Maybe use this event system later when the project grows
 */

namespace Core.EventSystem
{
    public static class EventController
    {
        public delegate void LightTouchedAction(Transform touchedTransform);
        public static event LightTouchedAction OnLightTouched;
        public static void TriggerOnLightTouchedEvent(Transform touchedTransform)
        {
            if (OnLightTouched != null)
            {
                OnLightTouched(touchedTransform);
                return;
            }

            Debug.LogError("OnLightTouched is null");
        }

        // TODO Create stop detection event


        public delegate void RestartLevelAction();
        public static event RestartLevelAction OnRestartLevel;
        public static void TriggerRestartLevelEvent()
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

