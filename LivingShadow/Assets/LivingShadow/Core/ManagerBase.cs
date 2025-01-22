using UnityEngine;

namespace Core
{
    public abstract class ManagerBase : MonoBehaviour
    {
        public abstract void SetupManager();
        public virtual void UpdateManager() { }
        public abstract void ClearManager();
    }
}
