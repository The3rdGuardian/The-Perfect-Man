using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vortexone : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Base2");
        }

    }
}
