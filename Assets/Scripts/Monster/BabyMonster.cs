using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMonster : Monster
{  
    public override void Death()
    {
        Debug.Log("BabyMonster�� ����߽��ϴ�.");
        Destroy(gameObject);
    }
}
