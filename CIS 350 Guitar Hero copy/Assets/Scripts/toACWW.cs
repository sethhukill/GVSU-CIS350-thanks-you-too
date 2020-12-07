using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toACWW : MonoBehaviour
{
    public void toACWWScene()
    {
        SceneManager.LoadScene("AnimalCrossing");
        
    }

    public void toWiiScene()
    {
        SceneManager.LoadScene("WiiTheme");
        
    }

    public void toStickerbushScene()
    {
        SceneManager.LoadScene("Stickerbush");
        
    }
}
