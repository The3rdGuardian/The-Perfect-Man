using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBAudio : MonoBehaviour
{
    public AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WreckingBall")
            audioSrc.Play();
    }
}