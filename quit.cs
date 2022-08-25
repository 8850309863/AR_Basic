using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    int sceneindex;
    void Start()
    {
        sceneindex = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {   if (Input.GetKeyDown(KeyCode.Escape))
             Application.Quit();
    }


}