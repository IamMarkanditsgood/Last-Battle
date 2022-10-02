using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSizeOfMeteorite : MonoBehaviour
{
    
    public void RandomSizes(GameObject obj)
    {
        float size;
        int probabilityOfSizeType;
        probabilityOfSizeType = Random.Range(0, 101);
        if (probabilityOfSizeType <= 50)
        {
            size = Random.Range(0.1f, 1.1f);
            gameObject.transform.localScale = new Vector3(size, size, size);
            // 0.1 to 1
        }
        else if (probabilityOfSizeType > 50 && probabilityOfSizeType <= 85)
        {
            size = Random.Range(1f, 5f);
            gameObject.transform.localScale = new Vector3(size, size, size);
            // 1 to 5 
        }
        else if (probabilityOfSizeType > 85)
        {
            size = Random.Range(5f, 20f);
            gameObject.transform.localScale = new Vector3(size, size, size);
            // 5 to 20
        }
        //gameObject.transform.localScale = new Vector3(size, size, size); „ому воно не бачить тут сайз

    }
}
