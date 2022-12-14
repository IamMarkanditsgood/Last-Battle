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
        private HealtheAndShieldController _healtheAndShieldController = new HealtheAndShieldController();
        private RunEffect _runEffect = new RunEffect();

        private GameObject _playerShip;

        private void Start()
        {

            _playerShip = gameObject;
            _playerData = GetComponent<PlayerData>();
            _playerData.Rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;

            for (int i = 0; i < _playerData.ParticleList.Count; i++)
            {
                _runEffect.StopEffect(_playerData.ParticleList[i]);
            }
        }
        private void Update()
        {
            _lookAt.LookAtCursor(_playerData, _playerShip);
            _mouseController.InputController(_playerData);
            if(!_healtheAndShieldController.CheckHealtheAndShield(_playerData.Health, _playerData.Shield, gameObject, true))
            {
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                _runEffect.PlayEffect(_playerData.GetParticleObject(ETypeOfEffect.PlayerDeath));
                Invoke("Death", 1);


            }
        }
        private void FixedUpdate()
        {
            if(_keyboardController.InputController(_playerData, _playerShip))
            {
                _runEffect.PlayEffect(_playerData.GetParticleObject(ETypeOfEffect.PlayerEngine));
            }
        }
        private void Death()
        {
            Time.timeScale = 0;
        }


    }
}
