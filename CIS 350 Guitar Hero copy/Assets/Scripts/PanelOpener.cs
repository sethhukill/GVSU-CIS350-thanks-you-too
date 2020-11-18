using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public bool isActive = false;
    public void showPause()
    {
        if (Panel != null)
        {
            isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
        
    }
    public void resume()
    {
        if (Panel != null)
        {
            
            Panel.SetActive(false);
        }
    }
}
