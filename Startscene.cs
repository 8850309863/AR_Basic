using UnityEngine;
using UnityEngine.SceneManagement;



public class Startscene : MonoBehaviour
{
    

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

  
}



  
   
