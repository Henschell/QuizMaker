﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToNextScene : MonoBehaviour {

    public void LoadLevel()
    {
        SceneManager.LoadScene("Start");
    }
}