using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyOnLoad : MonoBehaviour
{
    void Awake()
    {
            DontDestroyOnLoad(this.gameObject);     
    }
}

/*if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }*/