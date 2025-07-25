using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    AudioSource aud;
    //public int lesson; 
    void Start()
    {
        aud = GetComponent<AudioSource>();
        Debug.Log(aud); 
    }
    public void PlayClip()
    {
        Debug.Log("it's working"); 
        aud.Play();
    }
}
