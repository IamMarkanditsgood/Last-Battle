using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight 
{
    public void CheckMovementOfSight(GameObject sight)
    {
        Vector3 pointScrin = Camera.main.WorldToScreenPoint(sight.transform.position);
        sight.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScrin.z));
        sight.transform.position = new Vector3(sight.transform.position.x, 0, sight.transform.position.z);
    }
}
