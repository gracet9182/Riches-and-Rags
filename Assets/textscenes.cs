﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textscenes : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("e"))
            SceneManager.LoadScene("hotel2", LoadSceneMode.Single);
    }
}
