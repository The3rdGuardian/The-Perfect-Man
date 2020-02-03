using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject Vortex;
    public Transform gobject;

    Animator anim;

    public Player playerscript;
    public Animation_Switch Script;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Instantiate(Vortex, new Vector3((gobject.position.x),(gobject.position.y),(gobject.position.z)), Quaternion.identity);
        }

        if(other.gameObject.tag == "Bullet")
        {
            anim.SetInteger("Death", 1);
            Destroy(other.gameObject);
        }

    }
}
