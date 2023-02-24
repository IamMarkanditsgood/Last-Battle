using System.Collections;
using UnityEngine;

public class ShootFromLaserGun : MonoBehaviour, IStandardShoot // Still not finished
{
    private DataOfGun dataOfGun;

    private Coroutine _coroutine;

    private void Awake()
    {
        dataOfGun = GetComponent<DataOfGun>();
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

    public void Shoot()
    {
        if (dataOfGun.IsCharged)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                TouchingObjects touchingObjects = new TouchingObjects();
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                touchingObjects.CheckingObjectLayer(gameObject, hit.transform.gameObject);
                Debug.DrawLine(ray.origin, hit.point);
            }
            dataOfGun.IsCharged = false;
            _coroutine = StartCoroutine(WaitShoot(dataOfGun.ReCharge));
        }
    }
    
    public IEnumerator WaitShoot(float rechargeTime)
    {
        yield return new WaitForSeconds(rechargeTime);

        dataOfGun.IsCharged = true;
        StopCoroutine(_coroutine);
    }
}
