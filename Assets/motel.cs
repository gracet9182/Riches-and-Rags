using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class motel : MonoBehaviour
{
    private int count;
    static public int value;

    public Text countText;

    // Use this for initialization
    void Start()
    {
        SetCountText();
    }

    // Update is called once per frame
    public void run(string scenename)
    {
        if (value >= 30)
        {
            value = value - 30;
            SetCountText();
            SceneManager.LoadScene(scenename);
        }
    }

    void SetCountText()
    {
        if (countText != null)
        {
            countText.text = "Coins: " + value.ToString();
        }
    }
}