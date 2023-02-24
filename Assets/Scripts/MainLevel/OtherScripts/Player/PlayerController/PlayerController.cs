using UnityEngine;
using System.Collections.Generic;
using ShipData;
using InputDeviceControllers;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerData _playerData;
        private LevelData _levelData;
        private ObjectsComposition _objectsComposition;
        

        private EffectController effectController;

        private Sight sight = new Sight();
        private UILevelController _uiLevelController = new UILevelController();
        private InputKeyboardController _keyboardController = new InputKeyboardController();
        private InputMouseController _mouseController = new InputMouseController();
        private HealtheAndShieldController _healtheAndShieldController = new HealtheAndShieldController();

        private List<GameObject> _curentEngineEffect = new List<GameObject>();

        private GameObject _playerShip;
        private GameObject _curentEngineSound;

        private bool _engineSwithcer = true;
        private bool _isLive = true;
        
        private void Start()
        {
            _levelData = LevelData.instance;

            _playerShip = gameObject;
            _playerData = GetComponent<PlayerData>();
            _playerData.Rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
        }
        private void Update()
        {
            _playerShip.transform.LookAt(_playerData.Sight.transform, Vector3.up);
            _mouseController.InputController(_playerData);
            _uiLevelController.SetHPAndShield(_levelData.MainUIDatas.MainLevelUI, _playerData.GetHealth(), _playerData.GetShield());
            if (!_healtheAndShieldController.CheckHealtheAndShield(_playerData.GetHealth()) && _isLive)
            {
                PlayerDeath();
                Invoke("LossOfLevel", 1);
            }
        }
        private void FixedUpdate()
        {
            CheckInputController();
        }
        private void LateUpdate()
        {
            sight.CheckMovementOfSight(_playerData.Sight);
        }
        private void OnTriggerEnter(Collider collider)
        {
            CheckTouchedObj(collider);
        }

        private void CheckTouchedObj(Collider collider)
        {
            LayerMask layer = collider.gameObject.layer;

            if(layer == LayerMask.NameToLayer("Buff"))
            {
                collider.gameObject.GetComponent<IBuffUse>().UseBuff(gameObject);
            }
        }
        private void CheckInputController()
        {
            effectController = new EffectController();

            if (_keyboardController.InputController(_playerData, _playerShip) && _engineSwithcer)
            {
                effectController.RunEngineEffect(ETypeOfEffect.PlayerEngine, _playerData.Engines, ref _curentEngineEffect);

                _objectsComposition = ObjectsComposition.instance;
                _curentEngineSound = _objectsComposition.GetSound(ETypeOfSound.PlayerEngine);
                _curentEngineSound.SetActive(true);

                _engineSwithcer = false;
            }
            else if (!_keyboardController.InputController(_playerData, _playerShip) && !_engineSwithcer)
            {
                _curentEngineSound.SetActive(false);
                effectController.StopEngineEffect(_curentEngineEffect);

                _engineSwithcer = true;
            }
        }
        private void PlayerDeath()
        {
            _isLive = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            UseSoundAndEffectOfDeath();
        }
        private void LossOfLevel()
        {
            _levelData.LoseLevel = true;
        }
        private void UseSoundAndEffectOfDeath()
        {
            EffectController effectController = new EffectController();
            _objectsComposition = ObjectsComposition.instance;

            effectController.UseEffect(ETypeOfEffect.PlayerDeath, gameObject.transform);

            GameObject sound;
            sound = _objectsComposition.GetSound(ETypeOfSound.PlayerDeath);
            sound.transform.position = gameObject.transform.position;
            sound.SetActive(true);
            sound.AddComponent<cleaner>();
        }
    }
}
