using UnityEngine;

public class WallForce : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player duvara çarptı");
            rb.AddForce(Vector3.left * 500f);
        }
    }


}
