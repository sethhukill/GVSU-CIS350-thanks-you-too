using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toACWW : MonoBehaviour
{
    public void toACWWScene()
    {
        SceneManager.LoadScene("AnimalCrossing");
        Time.timeScale = 1;
    }

    public void toWiiScene()
    {
        SceneManager.LoadScene("WiiTheme");
        Time.timeScale = 1;
    }

    public void toStickerbrushScene()
    {
        SceneManager.LoadScene("Stickerbrush");
        Time.timeScale = 1;
    }
}
