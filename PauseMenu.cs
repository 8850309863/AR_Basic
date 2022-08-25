using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject PauseMenuUI;
    void Update()
    {
        
        
            if (GameisPaused)
            {
                Resume();
            }
           
        
    }
    public void Resume()
    {
        GameisPaused = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    
}