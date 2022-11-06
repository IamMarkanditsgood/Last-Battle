using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimer : MonoBehaviour
{
    
    private Coroutine _coroutine;

    private void OnEnable()
    {
       
        if (GetComponent<DataOfProjectile>().ScriptableObjects != null)
        {
            
            float _timeLife = GetComponent<DataOfProjectile>().ScriptableObjects.LifeTime;
            _coroutine = StartCoroutine(WaitDeath(_timeLife));
        }
    }

    private void OnDisable()
    {
        if(_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
        
    }

    private IEnumerator WaitDeath(float timeLife)
    {
        yield return new WaitForSeconds(timeLife);
        CleanPrefab cleanPrefab = new CleanPrefab();
        cleanPrefab.DeleteParticle(GetComponent<DataOfProjectile>());
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
}
