using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{

    //Player
    public TMP_Text PlayerHealthBox;
    public TMP_Text ItemCountBox;

    //Count down 
    public float StartTime = 60;
    public TMP_Text TimeBox;
    public UnityEvent UpdatePlayerHP;
    public UnityEvent UpdateItemCount;

    void Start()
    {
        SetPlayerHPUI();
        SetItemCount();

        UpdatePlayerHP.AddListener(SetPlayerHPUI);
        UpdateItemCount.AddListener(SetItemCount);
    } 

    void Update()
    {
        StartTime -= Time.deltaTime;
        TimeBox.text = Math.Round(StartTime).ToString();

        if (StartTime <= 0)
            GameManager.Instance.GameOver();
         
    }

    private void SetPlayerHPUI()
    {
        PlayerHealthBox.text = "PH : " + GameManager.Instance.player.HealthPoint.ToString();
    }

    private void SetItemCount()
    {
        ItemCountBox.text = "ITEM : " + GameManager.Instance.ItemCount.ToString();
    }


}
