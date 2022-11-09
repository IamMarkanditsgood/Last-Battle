using UnityEngine;
using ShipData;
using MoveMethods;

namespace InputDeviceControllers
{
    public class InputKeyboardController
    {
        public void InputController(PlayerData playerData, GameObject playerShip)
        {

            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                MovePlayer movePlayer = new MovePlayer();
                movePlayer.Movement(_movementVector, playerData, playerShip);
            }
        }
        private Vector3 _movementVector
        {
            get
            {
                var horizontal = Input.GetAxis("Horizontal");
                var vertical = Input.GetAxis("Vertical");
                return new Vector3(horizontal, 0.0f, vertical);
            }
        }
    }
}
