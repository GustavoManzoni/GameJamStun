using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGame : MonoBehaviour
{
    public GameObject menu;

    
    void Start()
    {
        menu.SetActive(false); 
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu.activeSelf)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        menu.SetActive(true);
        Time.timeScale = 0f; 
        
    }

    void ResumeGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1f; 
    }
}
