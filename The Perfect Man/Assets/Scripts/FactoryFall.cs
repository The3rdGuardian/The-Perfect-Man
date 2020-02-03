using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryFall : MonoBehaviour
{
    Animator anim;

    private Rigidbody2D rb2d;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WreckingBall")
        {
            anim.SetInteger("Fall", 1);
        }
    }
}
