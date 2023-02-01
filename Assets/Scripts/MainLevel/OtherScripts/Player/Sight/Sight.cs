using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    void LateUpdate()
    {
        Vector3 pointScrin = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScrin.z));
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
}
