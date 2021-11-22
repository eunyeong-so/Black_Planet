using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;
    private List<GameObject> pooledObjects = new List<GameObject>();
      
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
 
    public IEnumerator CreateObjectPool(GameObject poolObjectPrefab, int amountToPool, float timeGap)
    {
        if (pooledObjects != null) pooledObjects.Clear();

        for (int i = 0; i < amountToPool; i++)
        {
            yield return new WaitForSeconds(timeGap);
            GameObject obj = Instantiate(poolObjectPrefab);
            pooledObjects.Add(obj);
        }
    }

    public List<GameObject> GetPooledObjects()
    {
        return pooledObjects;
    }
     
}
