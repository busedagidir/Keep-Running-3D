using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerArms : MonoBehaviour
{
    float speed = 70.0f;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
