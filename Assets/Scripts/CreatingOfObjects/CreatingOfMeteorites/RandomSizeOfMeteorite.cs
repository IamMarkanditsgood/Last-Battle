using UnityEngine;

public class RandomSizeOfMeteorite
{
    private const int _maxProbability = 100;
    private const int _probabilityOfSpawningSmallMeteorite = _maxProbability - 50;
    private const int _probabilityOfSpawningMediumMeteorite = _maxProbability -  15;
    private const int _probabilityOfSpawningLargeMeteorite = _maxProbability - 15;

    public void RandomSizes(GameObject thisMeteorite)
    {
        float size;
        int probabilityOfSizeType;

        probabilityOfSizeType = Random.Range(0, 101);
        if (probabilityOfSizeType <= _probabilityOfSpawningSmallMeteorite)
        {
            size = Random.Range(0.1f, 1.1f);
            thisMeteorite.transform.localScale = new Vector3(size, size, size);
            // 0.1 to 1
        }
        else if (probabilityOfSizeType > _probabilityOfSpawningSmallMeteorite && probabilityOfSizeType <= _probabilityOfSpawningMediumMeteorite)
        {
            size = Random.Range(1f, 5f);
            thisMeteorite.transform.localScale = new Vector3(size, size, size);
            // 1 to 5 
        }
        else if (probabilityOfSizeType > _probabilityOfSpawningLargeMeteorite)
        {
            size = Random.Range(5f, 20f);
            thisMeteorite.transform.localScale = new Vector3(size, size, size);
            // 5 to 20
        }

    }
}
