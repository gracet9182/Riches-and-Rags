using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textscenetrigger3 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("e"))
            SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
    }
}
