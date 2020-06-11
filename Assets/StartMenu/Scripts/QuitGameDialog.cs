using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGameDialog : MonoBehaviour
{
    private GameObject exitMenu;
    private GameObject startMenu;

    void Start () {
        exitMenu = GameObject.Find("ExitMenu");
        startMenu = GameObject.Find("StartMenu");
        SwitchToStartMenu();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (startMenu.activeSelf) 
            {
                SwitchToExitMenu();
            } else 
            {
                SwitchToStartMenu();
            }
        }
    }

    public void SwitchToStartMenu() {
        startMenu.SetActive(true);
        exitMenu.SetActive(false);
    }

    public void SwitchToExitMenu() {
        startMenu.SetActive(false);
        exitMenu.SetActive(true);
    }

    public void ExitGame() {
    	Application.Quit();
    }
}
