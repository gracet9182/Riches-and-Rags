using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Aj_2 : MonoBehaviour
{

    static Animator anim;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

    private int count;
    static public int value = 0;

    public Text countText;

    public AudioSource audioWalk;
    public AudioSource audioPunch;
    public AudioClip impact;
    public AudioSource audioCoin;
    public AudioClip coin;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        count = 0;
        SetCountText();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Scene1(2)")
        {
            value = value - value;
            SetCountText();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        if (rotation != 0 && translation == 0)
        {
            transform.Translate(0, 0, 0.07f);
        }
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("is_attacking");
            audioPunch.PlayOneShot(impact, 0.7F);
        }
        if (translation == 0 && rotation == 0)
        {
            anim.SetBool("is_walking", false);
            audioWalk.enabled = false;
            audioWalk.loop = false;
        }
        else
        {
            anim.SetBool("is_walking", true);
            audioWalk.enabled = true;
            audioWalk.loop = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            audioCoin.PlayOneShot(coin, 0.7F);
            other.gameObject.SetActive(false);
            value = value + 10;
            SetCountText();
        }
    }
    public void motel(string scenename)
    {
        if (value >= 20)
        {
            value = value - 20;
            SetCountText();
            SceneManager.LoadScene(scenename);
        }
    }
    public void hotel(string scenename)
    {
        if (value >= 50)
        {
            value = value - 50;
            SetCountText();
            SceneManager.LoadScene(scenename);
        }
    }
    public void hotel2(string scenename)
    {
        if (value >= 500)
        {
            value = value - 500;
            SetCountText();
            SceneManager.LoadScene(scenename);
        }
    }

    public void motel2(string scenename)
    {
        if (value >= 60)
        {
            value = value - 60;
            SetCountText();
            SceneManager.LoadScene(scenename);
        }
    }

    public void motel4(string scenename)
    {
        if (value >= 10)
        {
            value = value - 10;
            SetCountText();
            SceneManager.LoadScene(scenename);
        }
    }

    public void hotel3(string scenename)
    {
        if (value >= 30)
        {
            value = value - 30;
            SetCountText();
            SceneManager.LoadScene(scenename);
        }
    }
    public void street2()
    {
        int randomNumber = Random.Range(1, 5);
        {
            if (randomNumber == 3)
            {
                SceneManager.LoadScene("unityStreets2");
            }
            else
            {
                SceneManager.LoadScene("lostallmoney");
            }
        }
    }
    public void streets22(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    void restartStatic()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene1"))
        {
            value = 0;
        }
    }
    void SetCountText()
    {
        countText.text = "Coins: " + value.ToString();
    }
}
