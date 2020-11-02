using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static float _currentHealth;
    private float _startHealth = 100f;
    private float _sawDamage = 10f;
    private float _lavaDamage = 20f;
    private float _collect = 15f;
    public HealthBar _healthBar;
    //public GameObject _coin;

    void Start()
    {
        _currentHealth = _startHealth;
        _healthBar.SetMaxHealth(_startHealth);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("coin collected");
            CollectHealth(_collect);
            Destroy(other.gameObject);
            
        }

        if (other.gameObject.tag == "Lava")
        {
            TakeDamage(_lavaDamage);
            Debug.Log(_currentHealth);
        }

        if (other.gameObject.tag == "CircularSaw")
        {
            TakeDamage(_sawDamage);
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
            SceneManager.LoadScene("DieScene");
        }
    }

    public void CollectHealth(float coin)
    {
        if(_currentHealth > 100)
        {
            _currentHealth = 100;
            _healthBar.SetHealth(_currentHealth);
        }
        else
        {
            _currentHealth += coin;
            _healthBar.SetHealth(_currentHealth);
        }
    }

}
