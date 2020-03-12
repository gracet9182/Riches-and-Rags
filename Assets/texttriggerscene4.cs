using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class texttriggerscene4 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("e"))
            SceneManager.LoadScene("Scene4", LoadSceneMode.Single);
    }
}
