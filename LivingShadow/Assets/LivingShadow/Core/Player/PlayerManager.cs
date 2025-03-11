using Core;
using UnityEngine;

namespace Core.Player
{
    public class PlayerManager : ManagerBase
    {
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private GameObject _playerSpawnPosition;

        private GameObject _instantiatedPlayer = null;
        

        public override void SetupManager()
        {
            if (_playerPrefab == null || _playerSpawnPosition == null)
            {
                Debug.LogError("PlayerManager is missing a reference");
                return;
            }

            if (_instantiatedPlayer == null)
            {
                _instantiatedPlayer = Instantiate(_playerPrefab);
            }

            _instantiatedPlayer.transform.position = _playerSpawnPosition.transform.position;
        }

        public override void ClearManager()
        {
        }
    }
}

