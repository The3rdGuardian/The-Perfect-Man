using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryBoss : MonoBehaviour
{
    public GameObject Vortex;
    public Transform gobject;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Vortex, new Vector3((gobject.position.x), (gobject.position.y), (gobject.position.z)), Quaternion.identity);
        }
    }
}
