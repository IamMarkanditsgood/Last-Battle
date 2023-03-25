using MoveMethods;
using ShipData;
using UnityEngine;

public class InputJoysticksController
{
    public bool MovementJoystick(Joystick joystick, PlayerData playerData, GameObject playerShip)
    {
        if (joystick != null)
        {
            if (joystick.Horizontal != 0 || joystick.Vertical != 0)
            {
                MovePlayer movePlayer = new MovePlayer();

                Vector3 vector = MovementVector(joystick);
                movePlayer.Movement(vector, playerData, playerShip);

                return true;
            }
        }

        return false;
    }
    
    public bool RotationJoystick(Joystick joystick, GameObject playerShip)
    {
        if (joystick != null)
        {
            if (joystick.Horizontal != 0 || joystick.Vertical != 0)
            {
                Rigidbody _rigidbody = playerShip.GetComponent<Rigidbody>();

                Vector3 vector = new Vector3(joystick.Horizontal, _rigidbody.velocity.y, joystick.Vertical);
                playerShip.transform.rotation = Quaternion.LookRotation(vector);

                return true;
            }
        }

        return false;
    }
    private Vector3 MovementVector(Joystick joystick)
    {
        var horizontal = joystick.Horizontal;
        var vertical = joystick.Vertical;
        return new Vector3(horizontal, 0.0f, vertical);
    }
}
