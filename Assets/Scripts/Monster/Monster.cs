using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IDamageable
{
    public MonsterData MonsterInfoData;
    private int strikingPower;
    private int healthPoint;
    private int item;
    private float time; 

    void Awake()
    {
        SetStat();
        SetMovement();
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time > MonsterInfoData.CoolTime)
        { 
            AttackThePlayer((DamageType)Random.Range(0, 2));
            time = 0;
        } 
    }

    public virtual int StrikingPower
    {
        get { return strikingPower; }
        set
        {
            strikingPower = value;
        }
    }

    public virtual int HealthPoint
    {
        get { return healthPoint; }
        set
        {
            healthPoint = value;
            if (healthPoint <= 0)
            {
                GetItemBox(item);
                Death();
            }
        }
    }

    public void SetStat() 
    {  
        strikingPower = MonsterInfoData.StrikingPower;
        healthPoint = MonsterInfoData.HP;
        item = MonsterInfoData.Item;
    }

    public void SetMovement()
    { 
        gameObject.AddComponent<MoveAlongBezier>().Routes = MonsterInfoData.MoveRoutes;
    }
     
    public virtual void Death()
    { 
    }

    private void GetItemBox(int max)
    {
        int newItem = Random.Range(0, max + 1);
        GameManager.Instance.ItemCount += newItem; 
        GameManager.Instance.UIManager.UpdateItemCount.Invoke();  

        Debug.Log("아이템 개수 : " + newItem);
    }

    public void AttackThePlayer(DamageType attack)
    { 
        if (HealthPoint > 0)
        { 
            GameManager.Instance.player.Damage(StrikingPower, attack);
            GameManager.Instance.UIManager.UpdatePlayerHP.Invoke();
        }
    }

    public void Damage(int strikingPower, DamageType damageType)
    {
        switch (damageType)
        {
            case DamageType.Attack:
                HealthPoint -= strikingPower;
                break;

            case DamageType.SpeicalAttack:
                HealthPoint -= strikingPower * 2;
                break;
        } 
    }

    public void PrintMonsterInfo()
    {
        Debug.Log("Name: " + MonsterInfoData.MonsterName);
        Debug.Log("HP: " + MonsterInfoData.HP);
        Debug.Log("StrikingPower: " + MonsterInfoData.StrikingPower);
    }
}
