using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using DG.Tweening;

public class Player : MonoBehaviour
{

    private float _startHealth = 100f;
    private float _currentHealth = 100f;
    public float _sawDamage = 10f;
    public float _rockDamage = 5f;
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
        else if(collision.gameObject.tag == "Rock")
        {
            TakeDamage(_rockDamage);
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
        }

        _healthBar.SetHealth(_currentHealth);

        if (_currentHealth == 0)
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



    //private Rigidbody rigidbody;
    //private float distanceToGround = 7.5f;
    //[SerializeField] private float moveSpeed = 80f;
    //public float jumpSpeed;

    //private Touch theTouch;
    //private Vector3 touchStartPosition, touchEndPosition;

    //private float inputX;


    //private void Start()
    //{
    //    rigidbody = GetComponent<Rigidbody>();
    //}

    //private bool IsGrounded()
    //{
    //    return Physics.Raycast(transform.position, Vector3.down, distanceToGround);
    //}

    //private void FixedUpdate()
    //{
    //    if (CrossPlatformInputManager.GetButtonDown("Jump") && IsGrounded())
    //    {
    //        rigidbody.AddForce(transform.up * jumpSpeed, ForceMode.Impulse);

    //    }
    //}

    ////inputla ilgili bişiler kullanıcaksak updatede yaparız bunu
    //private void Update()
    //{
    //    //Debug.Log(isGrounded());
    //    //Vector3 jumpVelocity = new Vector3(0f, jumpSpeed, 0f);


    //    //butona basınca saga sola hareket
    //    inputX = CrossPlatformInputManager.GetAxisRaw("Horizontal") * moveSpeed;
    //    transform.Translate(inputX * Time.deltaTime, 0f, 0f);

    //    /* 
    //    transform.position = new Vector3(value, transform.position.y, transform.position.z);
    //   */

    //    //başlar başlamaz hareket etmesi için
    //    transform.Translate(0, 0, moveSpeed * Time.deltaTime);

    //    if (Input.touchCount > 0)
    //    {
    //        theTouch = Input.GetTouch(0);

    //        if (theTouch.phase == TouchPhase.Stationary)
    //        {
    //            touchEndPosition = theTouch.position;
    //            moveSpeed = 0.0001f;
    //            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    //        }

    //        if (theTouch.phase == TouchPhase.Ended)
    //        {
    //            touchEndPosition = theTouch.position;
    //            moveSpeed = 55f;
    //            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    //        }


    //    }

    //}

}
