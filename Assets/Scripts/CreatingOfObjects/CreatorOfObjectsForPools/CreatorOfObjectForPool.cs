using UnityEngine;

public class CreatorOfObjectForPool
{
    public GameObject CreateObjectAndPrepearIt(GameObject obj, Transform ObjectsContainer)
    {
        GameObject currentObj = Object.Instantiate(obj);
        currentObj.SetActive(false);
        currentObj.transform.SetParent(ObjectsContainer);

        return currentObj;
    }
}
