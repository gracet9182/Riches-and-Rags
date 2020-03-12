using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class detecthit_skeleto : MonoBehaviour
{

    public Slider healthbar;
    Animator anim;
    public string opponent;
    public AudioSource death;
    public AudioClip deathclip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;
        healthbar.value -= 30;
        if (healthbar.value <= 0)
        {
            anim.SetBool("is_dead", true);
        }
    }

// Use this for initialization
void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthbar.value <= 0)
        {
            death.PlayOneShot(deathclip, 0.1f);
        }

    }
}
