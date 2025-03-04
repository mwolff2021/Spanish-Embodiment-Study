using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource aud;
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
