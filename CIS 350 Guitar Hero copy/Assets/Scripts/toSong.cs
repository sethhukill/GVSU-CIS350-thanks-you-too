using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toSong : MonoBehaviour
{
    public void toSongSelect()
    {
        SceneManager.LoadScene("SongSelect");
    }
}
