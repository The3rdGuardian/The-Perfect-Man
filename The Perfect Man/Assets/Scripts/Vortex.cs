using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vortex : MonoBehaviour
{
    public Player playerscript;
    //public Animation_Switch Script;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Base1");
        }

    }
}