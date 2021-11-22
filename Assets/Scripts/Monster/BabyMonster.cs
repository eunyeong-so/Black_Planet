using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMonster : Monster
{  
    public override void Death()
    {
        Debug.Log("BabyMonster가 사망했습니다.");
        Destroy(gameObject);
    }
}
