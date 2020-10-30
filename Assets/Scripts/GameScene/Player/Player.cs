using UnityEngine;

public class Player : MonoBehaviour
{
    private float _startHealth = 100f;
    private float _currentHealth = 100f;
    public float _sawDamage = 10f;
    private float _collect = 5f;
    private float _lavaDamage = 20f;

    public HealthBar _healthBar;

    void Start()
    {
        _currentHealth = _startHealth;
        _healthBar.SetMaxHealth(_startHealth);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CircularSaw")
        {
            TakeDamage(_sawDamage);
            Debug.Log(_currentHealth);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("coin collected");
            CollectHealth(_collect);
        }

        if (other.gameObject.tag == "Lava")
        {
            TakeDamage(_lavaDamage);
            Debug.Log(_currentHealth);
        }
    }

    //farklı farklı engeller için takedamage fonk olusturi parametre farklı olacak sekilde
    public void TakeDamage(float damage)
    {
        if(_currentHealth > 0)
        {
            _currentHealth -= damage;
            _healthBar.SetHealth(_currentHealth);
        }
        
        if (_currentHealth <= 0)
        {
            Debug.Log("You died");
            //die screen gelsin
        }
    }

    public void CollectHealth(float coin)
    {
        _currentHealth += coin;
        _healthBar.SetHealth(_currentHealth);
    }
}
