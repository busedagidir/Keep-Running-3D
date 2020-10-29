using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public CheckPointManager checkPointManager;
    public bool isMyTurn;
    public GameObject coin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(isMyTurn)
            {
                isMyTurn = false;
                Debug.Log(other.gameObject.name + " picked up coin!");
                coin.SetActive(false);
            }
        }
    }
}
