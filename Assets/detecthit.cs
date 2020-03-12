using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detecthit : MonoBehaviour {

    public Slider healthbar;
    Animator anim;
    public string opponent;
    public AudioSource audioDeath;
    public AudioClip death;

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("restart", LoadSceneMode.Single);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;
        healthbar.value -= 25;

        if (healthbar.value <= 0)
        {
            anim.SetBool("is_dead", true);
            audioDeath.enabled = true;
            StartCoroutine(ExecuteAfterTime(0.5f));
        }
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
