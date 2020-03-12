using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float walkSpeed = 2;
    public float runSpeed = 6;
    public float rotationSpeed = 100.0F;

    private Rigidbody rb;
    private int count;

    public Text countText;

    Animator animator;
    CharacterController controller;

    static Animator anim;

    void Start()
    {
        animator = GetComponent<Animator>();
        SetCountText();

        {
            anim = GetComponent<Animator>();
        }
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * walkSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
     
        if (translation != 0)
        {
            anim.SetBool("iswalking", true);
        }
        else
        {
            anim.SetBool("iswalking", false);
        }
    }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive(false);
                count = count + 10;
                SetCountText();
            }
        }

        void SetCountText()
        {
            countText.text = "Coins: " + count.ToString();
        }
    }
