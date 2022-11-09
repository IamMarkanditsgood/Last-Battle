using UnityEngine;
using ShipData;
using InputDeviceControllers;
using LookAtMethods;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerData _playerData;
   
        private InputKeyboardController _keyboardController = new InputKeyboardController();
        private InputMouseController _mouseController = new InputMouseController();
        private LookAtTheSight _lookAt = new LookAtTheSight();

        private GameObject _playerShip;

        private void Start()
        {
            _playerShip = gameObject;
            _playerData = GetComponent<PlayerData>();
            _playerData.Rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;

        }
        private void Update()
        {
            _lookAt.LookAtCursor(_playerData, _playerShip);
            _mouseController.InputController(_playerData);
        }
        private void FixedUpdate()
        {
            _keyboardController.InputController(_playerData, _playerShip);
        }

    }
}
