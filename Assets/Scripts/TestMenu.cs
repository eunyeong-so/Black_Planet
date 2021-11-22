using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMenu : MonoBehaviour
{ 
    [ContextMenu("TestAttack")]
    public void TestAttack()
    {/*
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.SetStat();
        
        Debug.Log("babyMonster 공격");
        gameManager.player.PlayerAttack(gameManager.babyMonster, DamageType.SpeicalAttack);
        Debug.Log("babyMonster health:" + gameManager.babyMonster.HealthPoint);

        Debug.Log("Player 공격");
        gameManager.babyMonster.Attack(DamageType.SpeicalAttack);
        Debug.Log("Player health:" + gameManager.player.HealthPoint);*/
    }
}
