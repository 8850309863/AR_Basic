using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Previous : MonoBehaviour
{   int sceneindex;
     void Start()
    {
        sceneindex = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {       
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(sceneindex - 1);
            }
    }
}
