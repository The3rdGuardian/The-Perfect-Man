using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public AudioSource audioSrc;
    Animator anim;
    //public GameObject other_destroyed;

    private void Start()
    {
        anim = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine("rope_cut");
            audioSrc.PlayDelayed(.5f);
            //Destroy(other_destroyed);
        }
    }

        IEnumerator rope_cut()
    {
    
        anim.SetInteger("cut", 1);
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        
    }
}
