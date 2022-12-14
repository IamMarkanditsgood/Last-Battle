using UnityEngine;
using ShipData;

namespace MoveMethods
{
    public class MovePlayer
    {
        private Rigidbody rb;
        public void Movement(Vector3 movementVector, PlayerData playerData, GameObject playerShip)
        {
            
            rb = playerData.Rigidbody;
            float maxSpeed = playerData.MaxSpeed;
            rb.AddForce(movementVector * playerData.PlayerSpeed, ForceMode.Impulse);
            
            if (rb.velocity.magnitude >= maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }
        }
    }
}
