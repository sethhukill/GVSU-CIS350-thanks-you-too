using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    int multiplier;
    int streak;
    
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("RockMeter", 25);
        PlayerPrefs.SetInt("Streak", 0);
        PlayerPrefs.SetInt("HighStreak", 0);
        PlayerPrefs.SetInt("Mult", 1);
        PlayerPrefs.SetInt("NotesHit", 0);
        PlayerPrefs.SetInt("Start", 1);
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

        if (streak > PlayerPrefs.GetInt("HighStreak"))
            PlayerPrefs.SetInt("HighStreak", streak);

        PlayerPrefs.SetInt("NotesHit", PlayerPrefs.GetInt("NotesHit") + 1);

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
        PlayerPrefs.SetInt("Start", 0);
        SceneManager.LoadScene("LoseScreen");
    }

    public void Win()
    {
        PlayerPrefs.SetInt("Start", 0);
        if (PlayerPrefs.GetInt("HighScore")< PlayerPrefs.GetInt("Score")) 
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        SceneManager.LoadScene("WinScreen");
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
