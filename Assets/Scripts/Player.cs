using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;

public class Player : MonoBehaviour,IDamageable
{
    private int healthPoint;
    private int strikingPower;
    public UnityEvent updateHP; 
      
    public int StrikingPower { get; set; }
    public int HealthPoint
    {
        get { return healthPoint; }
        set
        {
            healthPoint = value;
            if (healthPoint <= 0)
            {
                Death();
            }
        }
    }

    void Awake()
    {
        SetStat();
    }

    private void SetStat()
    {
        StrikingPower = 1;
        HealthPoint = 20;
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

    public void PlayerAttacksMonsters(Monster monster, DamageType damageType)
    {
        if (HealthPoint > 0)
            monster.Damage(StrikingPower, damageType);
    }

    private void Death()
    {
        Debug.Log("game over");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
