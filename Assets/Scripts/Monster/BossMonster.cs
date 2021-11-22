using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : Monster
{  
    public override void Death()
    {
        Debug.Log("BossMonster가 사망했습니다.");
        Destroy(gameObject);
    }
}