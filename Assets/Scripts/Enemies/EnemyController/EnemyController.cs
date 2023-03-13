using Assets.Scripts.Cleaners;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private ObjectsComposition _objectsComposition = ObjectsComposition.instance;
    private LevelData _levelData = LevelData.instance;
    private DataOfEnemies _dataOfEnemies;

    private NavMeshAgent _agent;

    private Vector3 _target;
    
    private bool _isOnTarget = true;
    
    private void Start()
    {
        _target = gameObject.transform.position;
        _agent = GetComponent<NavMeshAgent>();
        _dataOfEnemies = GetComponent<DataOfEnemies>();
    }

    private void Update()
    {
        HealtheAndShieldController healtheAndShieldController = new HealtheAndShieldController();
        if(!healtheAndShieldController.CheckHealtheAndShield(_dataOfEnemies.GetHealth()))
        {
            Death();
        }
        AIMoverController Movecontroller = new AIMoverController();
        Movecontroller.Move(ref _isOnTarget, ref _target, gameObject, _dataOfEnemies.Player, _dataOfEnemies, _agent);
    }

    private void FixedUpdate()
    {
        ViewIsOnShootDistance viewIsOnShootDistance = new ViewIsOnShootDistance();

        viewIsOnShootDistance.IsOnShootDistance(_dataOfEnemies.LayerMaskOfEnemy, gameObject, _dataOfEnemies.DistanceForShooting);

        gameObject.transform.LookAt(_dataOfEnemies.Player.transform.position);

    }

    private void Death()
    {
        RandomizerOfBuffs randomizerOfBuffs = new RandomizerOfBuffs();
        PrefabsStorey prefabsStorey = PrefabsStorey.instance;

        gameObject.SetActive(false);
        _levelData.Money += AddMoneyForPlayer();
        _levelData.Score += AddMoneyForPlayer();
        randomizerOfBuffs.SpawnRandomBuff(prefabsStorey, _levelData);

        switch (_dataOfEnemies.RaceOfShip)
        {
            case 0:

                UseEffect(ETypeOfEffect.ImperialShipDeath);
                UseSound(ETypeOfSound.ImperialDeath);

                break;

            case (ERacesOfShips)1:

                UseEffect(ETypeOfEffect.AlianShipDeath);
                UseSound(ETypeOfSound.AlianZergDeath);

                break;
        }
    }

    private int AddMoneyForPlayer()
    {
        EEnemiesType eEnemiesType = _dataOfEnemies.ScriptableObjectOfEnemy.TypeOfShip;
        int money = _levelData.BasickMoneyForEnemyKill;
        switch (eEnemiesType)
        {
            case 0:

                return money;
            case (EEnemiesType)1:

                return money * 2;

            case (EEnemiesType)2:

                return money * 3;

            case (EEnemiesType)3:

                return money * 4;

            case (EEnemiesType)4:

                return money * 5;

            case (EEnemiesType)5:

                return money * 6;
        }
        print("You did not add this type of ship in switch in EnemyController");
        return 0;
    }
    private void UseEffect(ETypeOfEffect eTypeOfEffect)
    {
        GameObject effect;

        effect = _objectsComposition.GetEffect(eTypeOfEffect);

        effect.transform.position = gameObject.transform.position;
        effect.SetActive(true);
        effect.AddComponent<Cleaner>();
    }

    private void UseSound(ETypeOfSound eTypeOfSound)
    {
        GameObject sound;

        sound = _objectsComposition.GetSound(eTypeOfSound);

        sound.transform.position = gameObject.transform.position;
        sound.SetActive(true);
        sound.AddComponent<Cleaner>();
    }
}
