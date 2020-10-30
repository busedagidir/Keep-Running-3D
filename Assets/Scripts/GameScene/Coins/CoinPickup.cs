using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] private float _speed = 50f;
    
    void Update()
    {
        transform.Rotate(Vector3.down * _speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            //setactiveli bişi koy
            Debug.Log(other.gameObject + " picked up the coin");
            
        }
    }
}
