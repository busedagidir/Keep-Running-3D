using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TrapController : MonoBehaviour
{

    //private Rigidbody rigidbody;
    //public Player _player;
    
    //// Start is called before the first frame update
    //void Start()
    //{
    //    rigidbody = GetComponent<Rigidbody>();
    //    StartCoroutine(Fall());
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}


    ////player trape gelince trap aşağı düşsün
    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.name == "Player")
    //    {
    //        Debug.Log("Kırmızı yere çarptı");
    //        //StartCoroutine(Fall());
    //        transform.position = new Vector3(transform.position.x, -20, transform.position.z);
    //        _player.jumpSpeed = 50;

    //        if (CrossPlatformInputManager.GetButtonDown("Jump"))
    //        {
    //            rigidbody.AddForce(transform.up * _player.jumpSpeed, ForceMode.Impulse);

    //        }
            

    //    }
    //}

    //void OnCollisionStay(Collision other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Debug.Log("aşağı iniyor");
    //        //rigidbody.AddForce(Vector3.down * 10, ForceMode.Impulse);
    //        _player.jumpSpeed = 50;

    //        if (CrossPlatformInputManager.GetButtonDown("Jump"))
    //        {
    //            rigidbody.AddForce(transform.up * _player.jumpSpeed, ForceMode.Impulse);

    //        }
    //    }
    //}

    //void OnCollisionExit(Collision other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        _player.jumpSpeed = 50;

    //        if (CrossPlatformInputManager.GetButtonDown("Jump"))
    //        {
    //            rigidbody.AddForce(transform.up * _player.jumpSpeed, ForceMode.Impulse);

    //        }
    //    }
    //}

    //IEnumerator Fall()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //}
}
