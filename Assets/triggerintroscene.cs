using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerintroscene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("e"))
            SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
    }
}
