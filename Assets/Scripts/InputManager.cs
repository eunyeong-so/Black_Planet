using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{ 
    void Update()
    {
        ClickedMonster();
    }

    void ClickedMonster()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll(ray, Mathf.Infinity);
            foreach (var hit in hits)
            {
                if (hit.collider)
                {
                    Monster selected = hit.collider.gameObject.GetComponent<Monster>();
                    GameManager.Instance.player.PlayerAttacksMonsters(selected, DamageType.Attack);
                }
            }
        }
    }
}
