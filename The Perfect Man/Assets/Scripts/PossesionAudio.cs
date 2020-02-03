using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossesionAudio : MonoBehaviour
{
    public AudioSource audioSrc1;

    private void Start()
    {
        audioSrc1 = GetComponent<AudioSource>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            audioSrc1.Play();
    }
}