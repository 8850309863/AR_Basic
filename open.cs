using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
    public GameObject panel;

    public void openpanel()
    {
        bool isActive = panel.activeSelf;
        panel.SetActive(!isActive);
    }
}
