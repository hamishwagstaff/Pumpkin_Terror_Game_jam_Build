using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseAudioScriopt : MonoBehaviour
{
    AudioSource audio;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && GameObject.FindObjectWithTag("Player").GetComponent<PlayerScript>().points != 0)
        {
            audio.Play();
        }
    }
}
