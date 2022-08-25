using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Object : MonoBehaviour
{
    public void object1()
    {
        SceneManager.LoadScene(2);
    }
    public void object2()
    {
        SceneManager.LoadScene(3);
    }
}
