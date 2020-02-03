using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Switch : MonoBehaviour
{
    public Animator anim;

    public Player PlayerScript;

    private Rigidbody2D rb2d;

    public bool isSword;
    public bool isGun;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Sword")
        {

            isSword = true;
            anim.SetInteger("State", 4);
        }
        if(other.gameObject.tag == "Transform")
        {
            isSword = false;
            anim.SetInteger("State", 0);
        }
        if (other.gameObject.tag == "Gun")
        {
            isGun = true;
            anim.SetInteger("State", 5);
        }

    }

   
    public void OnCollisionStay2D(Collision2D other)
    {
        float hozMovement = Input.GetAxis("Horizontal");
        if (isSword == false && isGun == false)
        {
            if (Mathf.Abs(hozMovement) > 0)
            {
                anim.SetInteger("State", 1);
            }
            //Idle anim//
            if (Mathf.Abs(hozMovement) == 0)
            {
                anim.SetInteger("State", 0);
            }

            if (Input.GetKey(KeyCode.W))
            {
                anim.SetInteger("State", 2);
            }
        }
    }
}
