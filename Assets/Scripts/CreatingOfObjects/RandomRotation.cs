using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
   public void RandomRotations(GameObject obj, float maxDegreeOfRotation)
   {
       
       float x = Random.Range(0f, maxDegreeOfRotation);
       float y = Random.Range(0f, maxDegreeOfRotation);
       float z = Random.Range(0f, maxDegreeOfRotation);
       obj.transform.rotation = Quaternion.Euler(x, y, z);
   }
}
