using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = (GameManager)FindObjectOfType(typeof(GameManager));

                if (_instance == null)
                    Debug.Log("no GameManager obj");
            }
            return _instance;
        }
    }

    public  Player player;
    public UIManager UIManager;
    public int ItemCount;

    private void Start()
    { 
    }
     

    public void GameOver()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("게임이 종료됐습니다");
    }
}

