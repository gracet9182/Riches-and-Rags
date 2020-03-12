﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class type : MonoBehaviour {
    public string msg = "Replace";
    private Text textComp;
    public float startDelay = 2f;
    public float typeDelay = 0.01f;
    public AudioClip putt;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine("TypeIn");
	}

    private void Awake()
    {
        textComp = GetComponent<Text>();
    }

    public IEnumerator TypeIn()
    {
        yield return new WaitForSeconds(startDelay);

        for(int i = 0; i <= msg.Length; i++)
        {
            textComp.text = msg.Substring(0, i);
            yield return new WaitForSeconds(typeDelay);
        }
    }

    public IEnumerator TypeOff()
    {
        for (int i = msg.Length; i >= 0; i--)
        {
            textComp.text = msg.Substring(0, i);
            yield return new WaitForSeconds(typeDelay);
        }
    }
}
