﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayGameAI()
    {
        SceneManager.LoadScene("Game - AI");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
