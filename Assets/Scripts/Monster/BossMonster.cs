using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : Monster
{  
    public override void Death()
    {
        Debug.Log("BossMonster�� ����߽��ϴ�.");
        Destroy(gameObject);
    }
}