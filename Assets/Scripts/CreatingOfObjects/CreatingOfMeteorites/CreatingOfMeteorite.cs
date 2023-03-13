using UnityEngine;

public class CreatingOfMeteorite : MonoBehaviour
{
    void Start()
    {
        RandomRotation randomRotation = new RandomRotation();
        RandomSizeOfMeteorite randomSize = new RandomSizeOfMeteorite();

        randomRotation.RandomRotations(gameObject, 360f);
        randomSize.RandomSizes(gameObject);
    }
}
