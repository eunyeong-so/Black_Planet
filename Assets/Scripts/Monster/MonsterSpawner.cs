using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MonsterType { BabyMonster, DevilMonster, BossMonster }

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject babyMonster;

    [SerializeField]
    private GameObject devilMonster;

    [SerializeField]
    private GameObject bossMonster;

    private List<GameObject> babyMonsters;
    private List<GameObject> devilMonsters;

    private void Start()
    {
        gameObject.AddComponent<ObjectPool>();

        SpawnMonster(babyMonster, 10);
        babyMonsters = ObjectPool.Instance.GetPooledObjects();
     
    /*    SpawnMonster(devilMonster, 20);
        devilMonsters = ObjectPool.Instance.GetPooledObjects();
     
        SpawnMonster(bossMonster);*/
    }

    public void SpawnMonster(GameObject prefab, int amount = 1)
    {
        if (amount <= 1)
        { 
            GameObject monster = Instantiate(prefab);
            monster.SetActive(false);
        }
        else
        { 
            StartCoroutine(ObjectPool.Instance.CreateObjectPool(prefab, amount, 1f));
        }
    }
}
