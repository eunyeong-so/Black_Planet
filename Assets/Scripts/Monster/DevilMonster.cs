using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilMonster : Monster
{  
    public override void Death()
    {
        Debug.Log("DevilMonster�� ����߽��ϴ�.");
        Destroy(gameObject);
    }     
}
