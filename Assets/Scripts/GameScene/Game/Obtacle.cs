using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obtacle : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //player ölecek
            GameManager.Instance.Die();
            Destroy(other.gameObject);
        }
    }
}
