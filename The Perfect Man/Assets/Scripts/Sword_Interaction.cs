using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Interaction : MonoBehaviour
{

    public AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
            audioSrc.Play();
            Destroy(gameObject);
        }
    }
