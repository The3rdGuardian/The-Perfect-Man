using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportaion : MonoBehaviour
{

    public GameObject Player;
    public GameObject Portal;


    public void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Collide");
        }

    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0);
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    }
}
