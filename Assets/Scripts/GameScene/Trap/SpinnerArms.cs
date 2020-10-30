using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerArms : MonoBehaviour
{
    float speed = 70.0f;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player çarka çarptı");
            rb.AddForce(Vector3.right * 1500f);
        }
    }
}
