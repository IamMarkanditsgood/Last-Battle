using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Cleaners
{
    public class Cleaner : MonoBehaviour
    {
        [SerializeField] private float _timeLife = 2;

        private Coroutine _coroutine;

        private void OnEnable()
        {
            _coroutine = StartCoroutine(WaitToClean(_timeLife));
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

            CleanEffectOrSound();
        }
        private void CleanEffectOrSound()
        {
            gameObject.SetActive(false);
            Destroy(gameObject.GetComponent<Cleaner>());
        }
    }
}