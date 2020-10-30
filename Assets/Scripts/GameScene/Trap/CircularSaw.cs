using UnityEngine;

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
        }
    }
}
