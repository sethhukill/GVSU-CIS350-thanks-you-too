using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int multiplier;
    int streak;
    
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("RockMeter", 25);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        ResetStreak();
    }

    public void AddStreak()
    {
        if (PlayerPrefs.GetInt("RockMeter") < 50)
            PlayerPrefs.SetInt("RockMeter", PlayerPrefs.GetInt("RockMeter") + 1);
        streak++;
        if (streak >= 24)
            multiplier = 4;
        else if (streak >= 16)
            multiplier = 3;
        else if (streak >= 8)
            multiplier = 2;
        else
            multiplier = 1;
        UpdateGUI();
    }

    public void ResetStreak()
    {
        PlayerPrefs.SetInt("RockMeter", PlayerPrefs.GetInt("RockMeter") - 2);
        if (PlayerPrefs.GetInt("RockMeter") < 0)
        {
            Lose();
        }
        streak = 0;
        multiplier = 1;
        UpdateGUI();
    }

    public void Lose()
    {
        print("You Lose!");
    }

    public void Win()
    {
        print("Your Win!");
    }

    void UpdateGUI()
    {
        PlayerPrefs.SetInt("Streak", streak);
        PlayerPrefs.SetInt("Mult", multiplier);
    }
    public int GetScore()
    {
        return 100 * multiplier;
    }
}
