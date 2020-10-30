using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallForce : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player duvara çarptı");
        }

    }
}
