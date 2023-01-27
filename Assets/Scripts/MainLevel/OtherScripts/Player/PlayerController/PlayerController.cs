using UnityEngine;
using ShipData;
using InputDeviceControllers;
using LookAtMethods;
using Unity.VisualScripting;
using System.Collections.Generic;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerData _playerData;

        private LevelData _levelData;
        private ObjectsComposition _objectsComposition;
        private InputKeyboardController _keyboardController = new InputKeyboardController();
        private InputMouseController _mouseController = new InputMouseController();
        private LookAtTheSight _lookAt = new LookAtTheSight();
        private HealtheAndShieldController _healtheAndShieldController = new HealtheAndShieldController();
        private RunEffect _runEffect = new RunEffect();
        private UILevelController _uiLevelController = new UILevelController();
        private EffectController effectController;
        private GameObject _playerShip;
        private bool _engineSwithcer = true;
        private bool _isLive = true;
        private GameObject _curentEngineSound;
        private List<GameObject> _curentEngineEffect = new List<GameObject>();


        private void Start()
        {
            _levelData = LevelData.instance;
            _playerShip = gameObject;
            _playerData = GetComponent<PlayerData>();
            _playerData.Rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationX;
        }
        private void Update()
        {

            _lookAt.LookAtCursor(_playerData, _playerShip);
            _mouseController.InputController(_playerData);
            _uiLevelController.SetHPAndShield(_levelData.MainDatas.MainLevelUI, _playerData.GetHealth(), _playerData.GetShield());
            if (!_healtheAndShieldController.CheckHealtheAndShield(_playerData.GetHealth()/*, _playerData.Shield, gameObject, true*/) && _isLive)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                EffectController effectController = new EffectController();
                effectController.UseExplosionEffect(ETypeOfEffect.PlayerDeath, gameObject);
                GameObject sound;
                _objectsComposition = ObjectsComposition.Instance;
                sound = _objectsComposition.GetSound(ETypeOfSound.PlayerDeath);
                sound.transform.position = gameObject.transform.position;
                sound.SetActive(true);
                sound.AddComponent<cleaner>();
                    
                Invoke("Death", 1);
                _isLive = false;

            }
        }
        private void FixedUpdate()
        {
            effectController = new EffectController();
            if (_keyboardController.InputController(_playerData, _playerShip) && _engineSwithcer)
            {

                
                effectController.RunEngineEffect(ETypeOfEffect.PlayerEngine, _playerData.Engines,ref _curentEngineEffect );
                print("³â³â");
                _objectsComposition = ObjectsComposition.Instance;
                
                _curentEngineSound = _objectsComposition.GetSound(ETypeOfSound.PlayerEngine);
                _curentEngineSound.SetActive(true);
                _engineSwithcer = false;
                
            }
            else if(!_keyboardController.InputController(_playerData, _playerShip) && !_engineSwithcer)
            {
               
                _curentEngineSound.SetActive(false);
                effectController.StopEngineEffect(_curentEngineEffect);
                _engineSwithcer = true;
            }
        }
        private void Death()
        {
            
            _levelData.LoseLevel = true;
        }

    }
}
