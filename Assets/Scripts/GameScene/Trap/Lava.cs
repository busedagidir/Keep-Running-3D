using UnityEngine;

public class Lava : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log(other.gameObject + " floor is lava");
        }
    }
}
