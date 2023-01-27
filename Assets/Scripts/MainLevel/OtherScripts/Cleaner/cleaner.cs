using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaner : MonoBehaviour
{
    private Coroutine _coroutine;
    private void OnEnable()
    {
        _coroutine = StartCoroutine(WaitToClean(2));
    }
    private void OnDisable()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

    }
    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
    public IEnumerator WaitToClean(float timeLife)
    {
        yield return new WaitForSeconds(timeLife);
        gameObject.SetActive(false);
        Destroy(gameObject.GetComponent<cleaner>());
    }
}
