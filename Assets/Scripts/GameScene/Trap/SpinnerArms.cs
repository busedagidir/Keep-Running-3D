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
}
