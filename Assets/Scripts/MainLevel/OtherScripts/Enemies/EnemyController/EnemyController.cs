using ShipData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private ObjectsComposition _objectsComposition = ObjectsComposition.Instance;
    private DataOfEnemies _dataOfEnemies;
    private LookAtPlayer _lookAtPlayer = new LookAtPlayer();
    private RunEffect _runEffect = new RunEffect();
    private bool _isOnTarget = true;
    private Vector3 _target;
    private NavMeshAgent _agent;
    void Start()
    {
        _target = gameObject.transform.position;
        _agent = GetComponent<NavMeshAgent>();
        _dataOfEnemies = GetComponent<DataOfEnemies>();
    }
    void Update()
    {
        HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();
        if(!healtheAndShieldController.CheckHealtheAndShield(_dataOfEnemies.GetHealth()/*, _dataOfEnemies.Shield, gameObject, false*/))
        {
            gameObject.SetActive(false);
            GameObject effect;
            GameObject sound;
            switch (_dataOfEnemies.RaceOfShip)
            {
                
                case 0:

                    effect = _objectsComposition.GetEffect(ETypeOfEffect.ImperialShipDeath);

                    effect.transform.position = gameObject.transform.position;
                    effect.SetActive(true);
                    effect.AddComponent<cleaner>();

                    sound = _objectsComposition.GetSound(ETypeOfSound.ImperialDeath);
                    sound.transform.position = gameObject.transform.position;
                    sound.SetActive(true);
                    sound.AddComponent<cleaner>();
                    break;
                case (ERacesOfShips)1:
                    effect = _objectsComposition.GetEffect(ETypeOfEffect.AlianShipDeath);

                    effect.transform.position = gameObject.transform.position;
                    effect.SetActive(true);
                    effect.AddComponent<cleaner>();

                    sound = _objectsComposition.GetSound(ETypeOfSound.AlianZergDeath);
                    sound.transform.position = gameObject.transform.position;
                    sound.SetActive(true);
                    sound.AddComponent<cleaner>();
                    break;
            }
            
        }
        AIMoverController Movecontroller = new AIMoverController();
        Movecontroller.Move(ref _isOnTarget, ref _target, gameObject, _dataOfEnemies.Player, _dataOfEnemies, _agent);
    }
    private void FixedUpdate()
    {
        ViewIsOnShootDistance viewIsOnShootDistance = new ViewIsOnShootDistance();
        viewIsOnShootDistance.IsOnShootDistance(_dataOfEnemies.LayerMaskOfEnemy, gameObject, _dataOfEnemies.DistanceForShooting);
        _lookAtPlayer.RotateOnPlayer(gameObject, _dataOfEnemies.Player);
        
    }
}
