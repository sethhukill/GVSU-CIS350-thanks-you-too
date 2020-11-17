using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseGame : MonoBehaviour
{
    public bool isPaused;
    public GameObject SoundOffButton;
    
    public void pause()
    {
        if(Time.timeScale == 1)
        {
            isPaused = true;
            
            Time.timeScale = 0;
           
        }
        else if (Time.timeScale == 0)
        {
            isPaused = false;
            
            Time.timeScale = 1;
            
        }
    }
    public void soundOff()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;

        }
        else
        {
            AudioListener.pause = true;
        }
    }
}
