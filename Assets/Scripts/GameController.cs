﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public GameObject PausedPanel;
    public GameObject EndPanel;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
        
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            Time.timeScale = 0;
            PausedPanel.SetActive(true);
            return;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            PausedPanel.SetActive(false);
            return;
        }
    }
    public void EndGame ()
    {
        Time.timeScale = 0;
        EndPanel.SetActive(true);
    }
}
