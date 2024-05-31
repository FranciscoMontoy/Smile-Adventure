using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerFM : MonoBehaviour
{
    public static GameManagerFM instance;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoint()
    {
        score += 10;
        // Update score UI
    }

    public void GameOver()
    {
        // Handle game over logic
    }

    public void RestartLevel()
    {
        // Restart current level
    }
}
