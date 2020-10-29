using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CircularSaw : MonoBehaviour
{
    [SerializeField] private float _speed = 150.0f;

    
    void Update()
    {
        transform.Rotate(Vector3.right * _speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log(other.gameObject + "çarptı");
            //Destroy(other.gameObject);
            //game over ui ekranı gelicek
        }
    }



}
