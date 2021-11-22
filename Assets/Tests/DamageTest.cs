using NUnit.Framework;
using UnityEngine;

public class DamageTest
{ 
    
    [Test]
    public void AttackToBoss()
    {/*
        GameManager gameManager = GameManager.Instance;
        Assert.IsNotNull(gameManager);
        gameManager.SetStat();
        
        int originBossHP = gameManager.bossMonster.HealthPoint;
        int expectedBossHP = originBossHP - gameManager.player.StrikingPower;
         
        gameManager.player.PlayerAttack(gameManager.bossMonster, DamageType.Attack);
         
        Assert.IsTrue(gameManager.bossMonster.HealthPoint.Equals(expectedBossHP));*/
    }


    [Test]
    public void AttackToPlayer()
    {
      /*  GameManager gameManager = GameManager.Instance;
        Assert.IsNotNull(gameManager);
        gameManager.SetStat();
         
        int originPlayerHP = gameManager.player.HealthPoint;
        int expectedPlayerHP = originPlayerHP - gameManager.bossMonster.StrikingPower;

        gameManager.bossMonster.Attack(DamageType.Attack);
     
        Assert.IsTrue(gameManager.player.HealthPoint.Equals(expectedPlayerHP));*/
    }
     
}
