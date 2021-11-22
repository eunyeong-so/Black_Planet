using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Monster Data", menuName ="ScriptableObject/MonsterData", order = 0)]
public class MonsterData : ScriptableObject 
{ 
    [SerializeField]
    private string monsterName;
    public string MonsterName { get { return monsterName; } }

    [SerializeField]
    private int hp;
    public int HP { get { return hp; } }

    [SerializeField]
    private int strikingPower;
    public int StrikingPower { get { return strikingPower; } }

    [SerializeField]
    private int coolTime;
    public int CoolTime { get { return coolTime; } }

    [SerializeField]
    private int item;
    public int Item { get { return item; } }

    [SerializeField]
    private Transform[] moveRoutes;
    public Transform[] MoveRoutes { get { return moveRoutes; } }
}
